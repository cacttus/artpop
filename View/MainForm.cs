using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ArtPop
{

    public partial class MainForm : MetroForm
    {
        public SettingsForm SettingsForm { get; private set; }
        public PictureViewerForm PictureViewerForm { get; private set; }
        public Sequencer Sequencer { get; private set; } = null;

        Dictionary<Keys, Action> Shortcuts = new Dictionary<Keys, Action>();
        int WalkingGuyInitialYFromBase = 0;
        Timer WalkingGuyTimer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            Globals.SetMainForm(this);
            //Initialize Settings.
            SettingsForm = new SettingsForm();
            SettingsForm.Show();
            SettingsForm.Hide();


            SetupShortcuts();

            WalkingGuyTimer = new Timer();
            WalkingGuyTimer.Interval = 60;
            WalkingGuyInitialYFromBase = _pbWalkingGuy.Location.Y - Height;

            WalkingGuyTimer.Tick += (x, y) =>
            {
                int xspd = 5;
                _pbWalkingGuy.Location = new Point(_pbWalkingGuy.Location.X + xspd, Height + WalkingGuyInitialYFromBase);
                if (_pbWalkingGuy.Location.X > Width)
                {
                    _pbWalkingGuy.Location = new Point(-_pbWalkingGuy.Width, Height + WalkingGuyInitialYFromBase);
                }

                if (PictureViewerForm != null)
                {
                    if (Sequencer != null)
                    {
                        float f = (float)(Sequencer.ElapsedMillis) / (float)(Sequencer.TotalExerciseTimeMillis);

                        PictureViewerForm.RepaintTimerPie(f);
                    }
                }
            };
            WalkingGuyTimer.Stop();

            Globals.SetExerciseTimer(_lblTimer);

            _lblTitle.Text = Globals.ProgramDescriptionShort + " v" + Globals.ProgramVersion;
        }

        #region Private: UI Methods
        private void MainForm_Load(object sender, EventArgs e)
        {
            Show();
            BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void _btnSettings_Click(object sender, EventArgs e)
        {
            this.SettingsForm.ShowDialog(this);
        }
        private void _btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = System.Windows.Forms.MessageBox.Show("Really Exit?", "Exit?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }
        private void _btnSession_Click(object sender, EventArgs e)
        {
            SessionEditorForm f = new SessionEditorForm();
            f.ShowDialog();
        }
        private void _btnPlay_Click(object sender, EventArgs e)
        {
            //Do not put other code here.
            PlayPauseAction();
        }
        private void _btnShuffle_Click(object sender, EventArgs e)
        {
            Sequencer.Shuffle();
        }
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //_pbWalkingGuy.Location = new Point(_pbWalkingGuy.Location.X, Height + WalkingGuyInitialYFromBase);
        }
        private void _btnStop_Click(object sender, EventArgs e)
        {
            StopTimerAction();

        }

        #endregion

        #region Override Methods

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return ProcessShortcuts(keyData);
        }
        public bool ProcessShortcuts(Keys keyData)
        {
            //Process Shortcuts
            if (Shortcuts.Keys.Contains(keyData))
            {
                Action act = null;
                if (Shortcuts.TryGetValue(keyData, out act))
                {
                    act();
                    return true;//handled;
                }
            }
            return false;
        }
        #endregion

        #region Public:Methods
        public void SetSearchStatus(string stat)
        {
            BeginInvoke((Action)(() =>
            {
                _lblStatus.Text = stat;
                this.SettingsForm?.SetSearchStatus(stat);
            }));
        }
        public void SetStatus(string stat)
        {
            BeginInvoke((Action)(() =>
            {
                _lblStatus.Text = stat;
            }));
        }
        public void UpdateData()
        {
            //Note the order of CBOSessions MUST match the session order.
            _cboSessions.Items.Clear();
            foreach (Session e in SettingsForm.Sessions)
            {
                _cboSessions.Items.Add(e.Name);
            }

            if (_cboSessions.Items.Count > 0)
            {
                _cboSessions.SelectedIndex = 0;
            }
        }

        #endregion

        #region Private:Methods


        private Session GetSelectedSession()
        {
            if (_cboSessions.SelectedIndex < 0)
            {
                return null;
            }
            return Globals.MainForm.SettingsForm.Sessions[_cboSessions.SelectedIndex];
        }
        public void ToggleFullscreenAction()
        {
            if (PictureViewerForm != null)
            {
                if (PictureViewerForm.Fullscreen == true)
                {
                    PictureViewerForm.ToggleFullscreen(false);
                }
            }
        }
        public void PlayPauseAction()
        {
            if (this.SettingsForm.FileCache.Files.Count == 0)
            {
                MessageBox.Show("Could not start session, no images were found.  Create a list of images by going to Settings and clicking 'Search'", "No images found.", MessageBoxButtons.OK);
            }
            if (GetSelectedSession() == null)
            {
                MessageBox.Show("Select a session in the dropdown box to start it.  " +
                    "If you don't have any sessions you can create one by clicking the Sessions button at the top.");
            }
            else
            {
                if (Sequencer == null || Sequencer.PlayState == PlayState.Stopped)
                {
                    if (PictureViewerForm == null)
                    {
                        PictureViewerForm = new PictureViewerForm();
                        PictureViewerForm.Show();
                    }

                    //We are initially starting a play.  if stopped reset sequencer to load fresh data.
                    Sequencer = new Sequencer(
                        GetSelectedSession(),
                        () =>
                        {
                            //UpdatePlaylist
                            _lsvPlaylist.Items.Clear();
                            foreach (string card in Sequencer.Cards)
                            {
                                _lsvPlaylist.Items.Add(card);
                            }
                        },
                        () =>
                        {
                            //CycleImage
                            if (PictureViewerForm == null)
                            {
                                PictureViewerForm = new PictureViewerForm();
                            }
                            PictureViewerForm.SetImage(Sequencer.CurrentCard);
                            PictureViewerForm.InstructionText = Sequencer.CurrentExercise.Instruction;
                        }
                    );
                }

                if (Sequencer.PlayState == PlayState.Playing)
                {
                    PauseTimer();
                }
                else if (Sequencer.PlayState == PlayState.Paused)
                {
                    ResumeTimer();
                }
                else if (Sequencer.PlayState == PlayState.Stopped)
                {
                    StartTimer();
                }
            }

        }
        private void StartTimer()
        {
            Sequencer.Start();

            ResumeTimer();
        }
        private void PauseTimer()
        {
            Sequencer.Pause();

            _btnPlay.BackgroundImage = new Bitmap(Properties.Resources.appbar_timer_play);
            WalkingGuyTimer.Stop();
            _pbWalkingGuy.Visible = false;
        }
        public void PictureViewerWidnowClosed()
        {
            PictureViewerForm = null;
            PauseTimer();
        }
        private void StopTimerAction()
        {
            Sequencer.Stop();


            _cboSessions.Enabled = _btnSession.Enabled = _btnSettings.Enabled = true;
            _btnPlay.BackgroundImage = new Bitmap(Properties.Resources.appbar_timer_play);
            WalkingGuyTimer.Stop();
            _pbWalkingGuy.Visible = false;
            _btnStop.Visible = false;
            if (PictureViewerForm != null)
            {
                PictureViewerForm.Close();
                PictureViewerForm = null;
            }

        }
        private void ResumeTimer()
        {
            Sequencer.Resume();

            _cboSessions.Enabled = _btnSession.Enabled = _btnSettings.Enabled = false;
            _btnPlay.BackgroundImage = new Bitmap(Properties.Resources.appbar_timer_pause);
            _pbWalkingGuy.Enabled = true;

            _btnStop.Visible = true;

            //Show Walking Guy Loading bar.
            _pbWalkingGuy.Location = new Point(-_pbWalkingGuy.Width, _pbWalkingGuy.Location.Y);
            WalkingGuyTimer.Start();
            _pbWalkingGuy.Visible = true;

            if (PictureViewerForm == null)
            {
                PictureViewerForm = new PictureViewerForm();
            }
            PictureViewerForm.Show();
        }
        private void SetupShortcuts()
        {
            Shortcuts = new Dictionary<Keys, Action>();
            Shortcuts.Add(Keys.F5, PlayPauseAction);
            Shortcuts.Add(Keys.Escape, ToggleFullscreenAction);
            Shortcuts.Add(Keys.F11, ToggleFullscreenAction);
            Shortcuts.Add(Keys.Space, PlayPauseAction);
            Shortcuts.Add(Keys.Right, () => { Globals.MainForm.Sequencer.SkipToNextCard(); });
            Shortcuts.Add(Keys.Left, () => { Globals.MainForm.Sequencer.SkipToPrevCard(); });
            Shortcuts.Add(Keys.E, () => { Globals.MainForm.Sequencer.ExcludeCurrentCard(); PictureViewerForm?.ShowLocalMessage("Trashed."); });
            Shortcuts.Add(Keys.F, () => {
                Globals.MainForm.Sequencer.ToggleFavoriteCurrentCard(); PictureViewerForm?.UpdateFavImage(); });

        }


        #endregion

        private void _lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            HelpForm f = new HelpForm();
            f.ShowDialog();
        }

        private void _btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void _btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
