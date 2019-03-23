using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private float _fTimerPiePct = 0;
        Rectangle Last_Bounds;
        int Init_Pic_Top = 0;
        private string _strImageLoc = "";

        public bool Fullscreen { get; private set; } = false;
        public string InstructionText
        {
            get
            {
                return _txtInstructions.Text;
            }
            set
            {
                _txtInstructions.Text = value;
            }
        }

        public PictureViewerForm()
        {
            InitializeComponent();

            Globals.SetExerciseTimer(_lblTimer);
        }
        public void SetImage(string imageLoc)
        {
            _strImageLoc = imageLoc;
            try
            {
                if (String.IsNullOrEmpty(imageLoc) == false)
                {
                    _pbImage.Image = new Bitmap(imageLoc);
                    _btnFavorite.Visible = true;
                }
                else
                {
                    _pbImage.Image = null;
                    _btnFavorite.Visible = false;
                }
            }
            catch (Exception ex)
            {
                this.ShowLocalMessage("Image file not found.  Please update file list in the settings dialog.");
                Globals.LogError(ex.ToString());
            }
            _pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            _pbImage.Refresh();

            //Update the favorite star in the corner.
            UpdateFavImage();
        }
        int _iLastMsgVisible = 0;
        private void PictureViewer_Load(object sender, EventArgs e)
        {
            Last_Bounds = Bounds;
            Init_Pic_Top = this._pbImage.Top;
            MaximizeBox = false;
            MinimizeBox = false;

            _pnlPie.UseCustomBackColor = true;
            _pnlPie.BackColor = Color.FromArgb(0, 0, 0, 0);//0 alpha


            if (Globals.MainForm.SettingsForm.IsFullscreenEnabled)
            {
                ToggleFullscreen(true);
            }
            if (Globals.MainForm.SettingsForm.ShowFullscreenDetails == false)
            {
                _btnRestore_Fullscreen.Visible = true;
                _pnlDetails.Visible = false;
                _txtInstructions.Visible = false;
                _pbImage.Height = _pnlDetails.Bottom - _pbImage.Location.Y;//Enlarge Picture Box
            }

            _pnlPie.Visible = Globals.MainForm.SettingsForm.ShowPie;

        }
        public void ShowLocalMessage(string msg)
        {
            _txtMessage.Text = msg;
            _txtMessage.Visible = true;
            _iLastMsgVisible = Environment.TickCount;
        }
        private void PictureViewerForm_Shown(object sender, EventArgs e)
        {
        }
        private void _lblTimer_Click(object sender, EventArgs e)
        {
        }
        private void _pbImage_Click(object sender, EventArgs e)
        {
        }
        public void ToggleFullscreen(bool fs)
        {
            Focus();

            //Formborderstyle is already "NONE" with Metroframework
            if (fs == true)
            {
                //   this.TopMost = true;//Annoying
                Last_Bounds = Bounds;
                //Formborderstyle is already "NONE" with Metroframework
                //  this.FormBorderStyle = FormBorderStyle.None;
                _pbImage.Top = 0;

                //Get the screen that the center of the window is in
                int cx = (Bounds.Right - Bounds.Left) / 2;
                int cy = (Bounds.Bottom - Bounds.Top) / 2;
                Screen s = Screen.FromPoint(new Point(cx, cy));

                Rectangle b2 = Screen.PrimaryScreen.Bounds;
                //    ControlBox = false; //Causes problems

                WindowState = FormWindowState.Maximized;
                BringToFront();
                Bounds = s.Bounds;//;
                Fullscreen = true;
            }
            else
            {
                //  ControlBox = true;
                //  MaximizeBox = false;
                //  MinimizeBox = false;

                _pbImage.Top = Init_Pic_Top;

                //  this.TopMost = true;//Annoying
                //Formborderstyle is already "NONE" with Metroframework
                //  this.FormBorderStyle = FormBorderStyle.FixedSingle;
                WindowState = FormWindowState.Normal;

                Bounds = Last_Bounds;
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
            ToggleFullscreen(!Fullscreen);
        }
        private void _btnRestore_Fullscreen_Click(object sender, EventArgs e)
        {
            ToggleFullscreen(!Fullscreen);
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
            Globals.MainForm.PictureViewerWindowClosed();//Makes sure it aint' dangling
        }
        public void RepaintTimerPie(float pct)
        {
            if ((Environment.TickCount - _iLastMsgVisible > 3000) && _txtMessage.Visible == true)
            {
                _txtMessage.Visible = false;
            }

            _fTimerPiePct = pct;
            _pnlPie.BackgroundImage = null;
            _pnlPie.Refresh();
        }
        private void _pnlPie_CustomPaint(object sender, MetroFramework.Drawing.MetroPaintEventArgs e)
        {
            int opacity = Globals.MainForm.SettingsForm.ShowPieOpacity;
            // Create pen.
            SolidBrush red = new SolidBrush(Color.FromArgb(opacity, 0, 174, 219));

            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(0, 0, _pnlPie.Width, _pnlPie.Height);

            // Create start and sweep angles.
            float startAngle = 0.0F;
            float sweepAngle = 360.0f * _fTimerPiePct;

            // Draw pie to screen.
            e.Graphics.FillPie(red, rect, startAngle, sweepAngle);
        }

        private void _btnFavorite_Click(object sender, EventArgs e)
        {
            Globals.MainForm.Sequencer.ToggleFavoriteCurrentCard();
            UpdateFavImage();

        }
        public void UpdateFavImage()
        {
            if (Globals.MainForm.Sequencer.IsCurrentCardFavorited())
            {
                _btnFavorite.Image = new Bitmap(Properties.Resources.star_solid);
            }
            else
            {
                _btnFavorite.Image = new Bitmap(Properties.Resources.star_hollow);
            }
        }

        private void _btnOpenImageInFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.OpenFolderAndSelectItem(System.IO.Path.GetDirectoryName(_strImageLoc), System.IO.Path.GetFileName(_strImageLoc));

                //string p = _strImageLoc;// @"C:\tmp\this path contains spaces, and,commas\target.txt";
                //string args = string.Format("/e, /select, \"{0}\"", p);

                //ProcessStartInfo info = new ProcessStartInfo();
                //info.FileName = "explorer";
                //info.Arguments = args;
                //Process.Start(info);
            }
            catch(Exception ex)
            {
                Globals.LogError("When trying to open image folder...\r\n " + ex.ToString());
            }
        }
    }
}
