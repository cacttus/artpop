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
    public partial class PictureViewerForm : MetroForm
    {
        public bool Fullscreen { get; private set; } = false;
        public string InstructionText { get {
                return _txtInstructions.Text;
            } set {
                _txtInstructions.Text = value;
            } }
        public PictureViewerForm()
        {
            InitializeComponent();

            Globals.SetExerciseTimer(_lblTimer);
        }
        public void SetImage(string imageLoc)
        {
            _pbImage.Image = new Bitmap(imageLoc);
            _pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            _pbImage.Refresh();
        }
        private void PictureViewer_Load(object sender, EventArgs e)
        {
        }
        private void PictureViewerForm_Shown(object sender, EventArgs e)
        {
            if (Globals.MainForm.SettingsForm.IsFullscreenEnabled)
            {
                ToggleFullscreen(true);
            }
            if (Globals.MainForm.SettingsForm.ShowFullscreenDetails == false)
            {
                _pnlDetails.Visible = false;
                _pbImage.Height = _pnlDetails.Bottom - _pbImage.Location.Y;//Enlarge Picture Box
            }
        }
        private void _lblTimer_Click(object sender, EventArgs e)
        {
        }
        private void _pbImage_Click(object sender, EventArgs e)
        {
        }
        public void ToggleFullscreen(bool fs)
        {
            if(fs == true)
            {
                //  this.TopMost = true;//Annoying
                this.BringToFront();
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                Fullscreen = true;
            }
            else
            {
                //  this.TopMost = true;//Annoying
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Normal;
                Fullscreen = false;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Do callback to main form to control us.
            return Globals.MainForm.ProcessShortcuts(keyData);
        }
        private void _btnPlay_Click(object sender, EventArgs e)
        {
           Globals.MainForm.PlayPauseAction();
        }
        private void _btnRestore_Click(object sender, EventArgs e)
        {
            ToggleFullscreen(false);
        }

        private void _btnNext_Click(object sender, EventArgs e)
        {
            Globals.MainForm.Sequencer.SkipToNextCard();
        }

        private void _btnPrevious_Click(object sender, EventArgs e)
        {
            Globals.MainForm.Sequencer.SkipToPrevCard();

        }

        private void PictureViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.MainForm.PictureViewerWidnowClosed();//Makes sure it aint' dangling
        }
    }
}
