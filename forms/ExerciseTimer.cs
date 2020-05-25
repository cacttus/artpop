using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace ArtPop
{
    public partial class ExerciseTimer : MetroUserControl
    {
        Timer Timer;

        public ExerciseTimer()
        {
            InitializeComponent();
        }

        public override Font Font
        {
            get
            {
                return _lblClocko.Font;
            }
            set
            {
                _lblClocko.Font = value;
            }
        }
        public override Color ForeColor
        {
            get
            {
                return _lblClocko.ForeColor;
            }
            set
            {
                _lblClocko.ForeColor = value;
            }
        }

        private void ExerciseTimer_Load(object sender, EventArgs e)
        {
            Timer = new Timer();
            Timer.Interval = 30;
            Timer.Tick += (x, y) =>
            {
                if (Globals.MainForm.Sequencer != null)
                {
                    if (Globals.MainForm.Sequencer.PlayState == PlayState.Playing)
                    {
                        int elapsed = Environment.TickCount - Globals.MainForm.Sequencer.ResumeTimeMillis;
                        int duration = Globals.MainForm.Sequencer.EndTimeMillis - Globals.MainForm.Sequencer.ResumeTimeMillis;
                        int remaining = duration - elapsed;

                        TimeSpan ts = TimeSpan.FromMilliseconds(remaining);
                        string format = "";
                        //if (ts.Hours > 0)
                        //{
                            format = @"hh\:mm\:ss";
                        //}
                        //else if (ts.Minutes > 0)
                        //{
                        //    format = @"mm\:ss";
                        //}
                        //else if (ts.Seconds > 0)
                        //{
                        //    format = @"ss";
                        //}
                        //else
                        //{
                        //    format = "ffff";
                        //}


                        _lblClocko.Text = ts.ToString(format);

                        if(Globals.MainForm.Sequencer.CurrentExerciseRepeatCount > 1)
                        {
                            _lblClocko.Text += " x " + Globals.MainForm.Sequencer.CurrentExerciseRepeatCount;
                        }

                        _lblClocko.ForeColor = Color.FromArgb(100, 100, 100);

                    }
                    else if (Globals.MainForm.Sequencer.PlayState == PlayState.Stopped)
                    {
                        _lblClocko.Text = "0:00";
                        _lblClocko.ForeColor = Color.FromArgb(60, 60, 60);
                    }
                    else
                    {
                        //Paused
                        _lblClocko.ForeColor = Color.FromArgb(60, 60, 60);
                    }
                }
                else
                {
                    _lblClocko.Text = "0:00";
                    _lblClocko.ForeColor = Color.FromArgb(60, 60, 60);
                }

                Timer.Start();
            };
            Timer.Start();
        }
        private void _lblClocko_Click(object sender, EventArgs e)
        {
        }
        private void _lblClocko_SizeChanged(object sender, EventArgs e)
        {
            this.Width = _lblClocko.Width;
            this.Height = _lblClocko.Height;
        }
    }
}
