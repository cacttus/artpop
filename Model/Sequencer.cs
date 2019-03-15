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


        public int TotalExerciseTimeMillis { get; private set; } = 0;//Absolute beginning of timer
        public int ResumeTimeMillis { get; private set; } = 0;//the beginning of the last tim we paused, or the BeginTimeMillis if we never paused
        public int EndTimeMillis { get; private set; } = 0;//end of timer.
        public Timer ExerciseTimer { get; private set; } = null;//When we show the next picture
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

        private int ElapsedSinceRunMillis = 0;//Time elapsed since we last clicked "play"
        public float ElapsedMillis
        {
            get
            {
                float sincePause = Environment.TickCount - ResumeTimeMillis;
                return sincePause + ElapsedSinceRunMillis;
            }
        }

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
            int duration = EndTimeMillis - ResumeTimeMillis;
            int elapsed = Environment.TickCount - ResumeTimeMillis;
            DurationRemaining = duration - elapsed;
        }
        public void Resume()
        {
            if (PlayState == PlayState.Paused)
            {
                PlayState = PlayState.Playing;
                ExerciseTimer.Start();

                ResumeTimeMillis = Environment.TickCount;
                EndTimeMillis = ResumeTimeMillis + DurationRemaining;

                OnExerciseStart?.Invoke();
            }
            else
            {
                Globals.LogError("Error - play state was not paused before Resume() called.");
            }
        }
        public void Pause()
        {
            ElapsedSinceRunMillis += Environment.TickCount - ResumeTimeMillis;

            PlayState = PlayState.Paused;

            ExerciseTimer?.Stop();
            UpdateDurationRemaining();
        }
        public void Stop()
        {
            ResetState();

            OnShuffle?.Invoke();
        }
        public void Shuffle()
        {
            try
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
                    if (Unplayed.Count == 0)
                    {
                        //No Cards Left
                        break;
                    }
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
            catch (Exception ex)
            {
                Globals.LogError(ex.ToString());
            }
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
        public bool IsCurrentCardFavorited()
        {
            if (Globals.MainForm.SettingsForm.FileCache != null)
            {
                return Globals.MainForm.SettingsForm.FileCache.FavoritedFiles.Contains(CurrentCard);
            }
            return false;
        }
        public void ToggleFavoriteCurrentCard()
        {
            if (CurrentCard != "" && CurrentCard != null)
            {
                Globals.MainForm.SettingsForm.ToggleFavoriteFile(CurrentCard);
            }
        }
        public void ExcludeCurrentCard()
        {
            if (CurrentCard != "" && CurrentCard != null)
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
            if (CurrentExerciseIndex >= Session.Exercises.Count)
            {
                //We completed the session.
                System.Windows.Forms.MessageBox.Show("Session Complete. Press ESC or F11 to exit picture viewer.", "Session Complete", MessageBoxButtons.OK);
            }
            else
            {
                int exid = Session.Exercises[CurrentExerciseIndex];
                CurrentExercise = Globals.MainForm.SettingsForm.Exercises.Where(x => x.Id == exid).FirstOrDefault();

                //invoke a first tick to start the current exercise.
                NextCard();
                OnExerciseStart?.Invoke();

                //Start the timer for subsequent Exercises.
                ExerciseTimer.Stop();
                TotalExerciseTimeMillis = (int)CurrentExercise.Duration.TotalMilliseconds;
                ExerciseTimer.Interval = TotalExerciseTimeMillis;

                ResumeTimeMillis = Environment.TickCount;
                EndTimeMillis = ResumeTimeMillis + ExerciseTimer.Interval;
                UpdateDurationRemaining();

                ExerciseTimer.Start();
            }

        }
        private void ResetState()
        {
            PlayState = PlayState.Stopped;
            ExerciseTimer?.Stop();
            ExerciseTimer = null;

            Cards.Clear();
            CardIndex = 0;
            CurrentCard = null;
            ResumeTimeMillis = 0;
            EndTimeMillis = 0;
            TotalExerciseTimeMillis = 0;
            CurrentExerciseIndex = 0;
            ElapsedSinceRunMillis = 0;
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
