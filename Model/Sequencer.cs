using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtPop
{
    public enum PlayState
    {
        Playing,
        Paused,
        Stopped
    }
    /// <summary>
    /// Manages the sequencing of images "cards" in the deck (gathered images from disk).
    /// Also Manages the timer state, and the Exercise State
    /// </summary>
    public class Sequencer
    {
        private int DeckSize = 3;
        private int CardIndex = 0;

        public int StartTimeMillis { get; private set; } = 0;
        public int EndTimeMillis { get; private set; } = 0;
        public Timer ExerciseTimer { get; private set; } = null;
        public Exercise CurrentExercise { get; private set; } = null;

        public PlayState PlayState { get; private set; } = PlayState.Stopped;
        public string CurrentCard { get; private set; } = null;

        public List<string> Cards { get; private set; } = new List<string>();
        private List<string> Played = new List<string>();
        private List<string> Unplayed = new List<string>();

        int DurationRemaining = 0;

        private Action OnShuffle = null;
        private Action OnExerciseStart = null;
        private Session Session = null;
        private int CurrentExerciseIndex = 0;

        private Random Random = new Random();

        #region Public: Methods
        public Sequencer(Session session, Action onShuffle, Action onExerciseStart)
        {
            OnShuffle = onShuffle;
            OnExerciseStart = onExerciseStart;
            Session = session;
            //If the filecache isn't built then build it.
            if (Globals.MainForm.SettingsForm.FileCache.Files.Count == 0)
            {
                Globals.LogInfo("Sequencer: File cache wasn't built.");
                Globals.MainForm.SettingsForm.RefreshFileCache();
            }

            Globals.LogInfo("Sequencer: Copying files to unplayed");
            //Copy files to Unplayed.
            Unplayed = new List<string>(Globals.MainForm.SettingsForm.FileCache.Files);
        }
        public void Start()
        {
            ResetState();

            ExerciseTimer = new Timer();
            ExerciseTimer.Tick += (x, y) =>
            {
                OnExerciseStart?.Invoke();

                RunExercise(CurrentExerciseIndex++);
            };


            RunExercise(0);
        }
        private void UpdateDurationRemaining()
        {
            int duration = EndTimeMillis - StartTimeMillis;
            int elapsed = Environment.TickCount - StartTimeMillis;
            DurationRemaining = duration - elapsed;
        }
        public void Resume()
        {
            PlayState = PlayState.Playing;
            ExerciseTimer.Start();

            StartTimeMillis = Environment.TickCount;
            EndTimeMillis = StartTimeMillis + DurationRemaining;

            OnExerciseStart?.Invoke();
        }
        public void Pause()
        {
            PlayState = PlayState.Paused;
            ExerciseTimer.Stop();
            UpdateDurationRemaining();
        }
        public void Stop()
        {
            ResetState();

            OnShuffle?.Invoke();
        }
        public void Shuffle()
        {
            //Add our current hand into the played pile and add the unplayed back.
            for (int i = 0; i < CardIndex; ++i)
            {
                if (Cards.Count > 0)
                {
                    Played.Add(Cards[0]);
                    Cards.RemoveAt(0);
                }
            }

            CardIndex = 0;

            foreach (string card in Cards)
            {
                Unplayed.Add(card);
            }

            Cards.Clear();

            //get a new hand from the unplayed
            for (int i = 0; i < DeckSize; ++i)
            {
                //Cards.Add()
                int index = Random.Next() % Unplayed.Count;
                string card = Unplayed[index];

                if (Globals.MainForm.SettingsForm.RepeatCards == false)
                {
                    //remove
                    Unplayed.RemoveAt(index);
                }

                Cards.Add(card);
            }

            OnShuffle?.Invoke();
        }
        #endregion

        public void SkipToNextCard()
        {
            NextCard();
            OnExerciseStart?.Invoke();
        }
        public void SkipToPrevCard()
        {
            PrevCard();
            OnExerciseStart?.Invoke();
        }
        public void ExcludeCurrentCard()
        {
            if(CurrentCard!="" && CurrentCard != null)
            {
                Globals.MainForm.SettingsForm.ExcludeFile(CurrentCard);
                if (CardIndex < 0)
                {
                    if (Played.Count - CardIndex >= 0)
                    {
                        Played.RemoveAt(Played.Count - CardIndex);
                    }
                }
                else
                {
                    if (CardIndex < Cards.Count)
                    {
                        Cards.RemoveAt(CardIndex);
                    }
                }
                SkipToNextCard();
            }
        }
        #region Private:Methods
        private void RunExercise(int index)
        {
            int exid = Session.Exercises[CurrentExerciseIndex];
            CurrentExercise = Globals.MainForm.SettingsForm.Exercises.Where(x => x.Id == exid).FirstOrDefault();


            //invoke a first tick to start the current exercise.
            NextCard();
            OnExerciseStart?.Invoke();

            //Start the timer for subsequent Exercises.
            ExerciseTimer.Stop();
            ExerciseTimer.Interval = (int)CurrentExercise.Duration.TotalMilliseconds;

            StartTimeMillis = Environment.TickCount;
            EndTimeMillis = StartTimeMillis + ExerciseTimer.Interval;
            UpdateDurationRemaining();

            ExerciseTimer.Start();

        }
        private void ResetState()
        {
            PlayState = PlayState.Stopped;
            ExerciseTimer?.Stop();
            ExerciseTimer = null;

            Cards.Clear();
            CardIndex = 0;
            CurrentCard = null;
            StartTimeMillis = 0;
            EndTimeMillis = 0;
            CurrentExerciseIndex = 0;
        }

        private void PrevCard()
        {
            CardIndex--;
            DrawCard();
        }
        private void NextCard()
        {
            CardIndex++;
            DrawCard();
        }
        private void DrawCard()
        {
            if (CardIndex < 0)
            {
                if (Played.Count == 0)
                {
                    CardIndex = 0;
                    if (Cards.Count > 0)
                    {
                        CurrentCard = Cards[0];
                    }
                    else
                    {
                        Shuffle();
                        if (Cards.Count > 0)
                        {
                            CurrentCard = Cards[0];
                        }
                    }
                }
                else if (Played.Count + CardIndex < 0)
                {
                    CurrentCard = Played[0];
                    CardIndex = -Played.Count;
                }
                else
                {
                    CurrentCard = Played[Played.Count + CardIndex];
                }
            }
            else
            {
                if (CardIndex >= Cards.Count)
                {
                    //Shuffle hand into played deck and get a new deck
                    Shuffle();
                }
                CurrentCard = Cards[CardIndex];
            }
        }

        #endregion





    }
}
