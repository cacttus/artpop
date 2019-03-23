namespace ArtPop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._cboSessions = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this._btnSettings = new MetroFramework.Controls.MetroButton();
            this._btnSession = new MetroFramework.Controls.MetroButton();
            this._lblTimer = new System.Windows.Forms.Label();
            this._lblTitle = new MetroFramework.Controls.MetroLabel();
            this._btnStop = new MetroFramework.Controls.MetroButton();
            this._pbWalkingGuy = new System.Windows.Forms.PictureBox();
            this._btnPlay = new MetroFramework.Controls.MetroButton();
            this._btnShuffle = new MetroFramework.Controls.MetroButton();
            this._btnNext = new MetroFramework.Controls.MetroButton();
            this._btnPrevious = new MetroFramework.Controls.MetroButton();
            this._lsvPlaylist = new MetroFramework.Controls.MetroListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbWalkingGuy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(20, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(459, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _lblStatus
            // 
            this._lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(45, 17);
            this._lblStatus.Text = "Ready..";
            // 
            // _cboSessions
            // 
            this._cboSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cboSessions.FormattingEnabled = true;
            this._cboSessions.ItemHeight = 23;
            this._cboSessions.Location = new System.Drawing.Point(82, 145);
            this._cboSessions.Name = "_cboSessions";
            this._cboSessions.Size = new System.Drawing.Size(351, 29);
            this._cboSessions.TabIndex = 5;
            this._cboSessions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._cboSessions.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this._btnSettings);
            this.panel1.Controls.Add(this._btnSession);
            this.panel1.Location = new System.Drawing.Point(20, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 42);
            this.panel1.TabIndex = 7;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.BackgroundImage = global::ArtPop.Properties.Resources.appbar_question;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(417, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(39, 37);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // _btnSettings
            // 
            this._btnSettings.BackgroundImage = global::ArtPop.Properties.Resources.appbar_cog;
            this._btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnSettings.Location = new System.Drawing.Point(3, 3);
            this._btnSettings.Name = "_btnSettings";
            this._btnSettings.Size = new System.Drawing.Size(67, 36);
            this._btnSettings.TabIndex = 3;
            this._btnSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnSettings.UseSelectable = true;
            this._btnSettings.Click += new System.EventHandler(this._btnSettings_Click);
            // 
            // _btnSession
            // 
            this._btnSession.BackgroundImage = global::ArtPop.Properties.Resources.appbar_layer_thick;
            this._btnSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnSession.Location = new System.Drawing.Point(76, 3);
            this._btnSession.Name = "_btnSession";
            this._btnSession.Size = new System.Drawing.Size(71, 36);
            this._btnSession.TabIndex = 3;
            this._btnSession.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnSession.UseSelectable = true;
            this._btnSession.Click += new System.EventHandler(this._btnSession_Click);
            // 
            // _lblTimer
            // 
            this._lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lblTimer.AutoSize = true;
            this._lblTimer.Font = new System.Drawing.Font("Adobe Caslon Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTimer.ForeColor = System.Drawing.Color.DimGray;
            this._lblTimer.Location = new System.Drawing.Point(136, 164);
            this._lblTimer.Name = "_lblTimer";
            this._lblTimer.Size = new System.Drawing.Size(271, 109);
            this._lblTimer.TabIndex = 2;
            this._lblTimer.Text = "0:0:0000";
            this._lblTimer.Click += new System.EventHandler(this._lblTimer_Click);
            // 
            // _lblTitle
            // 
            this._lblTitle.AutoSize = true;
            this._lblTitle.Location = new System.Drawing.Point(122, 29);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(162, 19);
            this._lblTitle.TabIndex = 6;
            this._lblTitle.Text = "ArtPop - Art Practice Tool";
            this._lblTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _btnStop
            // 
            this._btnStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._btnStop.BackgroundImage = global::ArtPop.Properties.Resources.appbar_timer_stop;
            this._btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnStop.Location = new System.Drawing.Point(249, 246);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(62, 51);
            this._btnStop.TabIndex = 9;
            this._btnStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnStop.UseSelectable = true;
            this._btnStop.Visible = false;
            this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
            // 
            // _pbWalkingGuy
            // 
            this._pbWalkingGuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._pbWalkingGuy.Enabled = false;
            this._pbWalkingGuy.Image = global::ArtPop.Properties.Resources.mario_run_gif;
            this._pbWalkingGuy.Location = new System.Drawing.Point(5, 474);
            this._pbWalkingGuy.Name = "_pbWalkingGuy";
            this._pbWalkingGuy.Size = new System.Drawing.Size(23, 22);
            this._pbWalkingGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pbWalkingGuy.TabIndex = 8;
            this._pbWalkingGuy.TabStop = false;
            this._pbWalkingGuy.Visible = false;
            // 
            // _btnPlay
            // 
            this._btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._btnPlay.BackgroundImage = global::ArtPop.Properties.Resources.appbar_timer_play;
            this._btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnPlay.Location = new System.Drawing.Point(82, 246);
            this._btnPlay.Name = "_btnPlay";
            this._btnPlay.Size = new System.Drawing.Size(141, 51);
            this._btnPlay.TabIndex = 4;
            this._btnPlay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnPlay.UseSelectable = true;
            this._btnPlay.Click += new System.EventHandler(this._btnPlay_Click);
            // 
            // _btnShuffle
            // 
            this._btnShuffle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnShuffle.BackgroundImage = global::ArtPop.Properties.Resources.appbar_shuffle;
            this._btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnShuffle.Location = new System.Drawing.Point(379, 82);
            this._btnShuffle.Name = "_btnShuffle";
            this._btnShuffle.Size = new System.Drawing.Size(68, 35);
            this._btnShuffle.TabIndex = 4;
            this._btnShuffle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnShuffle.UseSelectable = true;
            this._btnShuffle.Click += new System.EventHandler(this._btnShuffle_Click);
            // 
            // _btnNext
            // 
            this._btnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnNext.BackgroundImage = global::ArtPop.Properties.Resources.appbar_navigate_next;
            this._btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnNext.Location = new System.Drawing.Point(416, 10);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(31, 40);
            this._btnNext.TabIndex = 11;
            this._btnNext.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnNext.UseSelectable = true;
            this._btnNext.Click += new System.EventHandler(this._btnNext_Click);
            // 
            // _btnPrevious
            // 
            this._btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnPrevious.BackgroundImage = global::ArtPop.Properties.Resources.appbar_navigate_previous;
            this._btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnPrevious.Location = new System.Drawing.Point(379, 10);
            this._btnPrevious.Name = "_btnPrevious";
            this._btnPrevious.Size = new System.Drawing.Size(31, 40);
            this._btnPrevious.TabIndex = 10;
            this._btnPrevious.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnPrevious.UseSelectable = true;
            this._btnPrevious.Click += new System.EventHandler(this._btnPrevious_Click);
            // 
            // _lsvPlaylist
            // 
            this._lsvPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsvPlaylist.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._lsvPlaylist.FullRowSelect = true;
            this._lsvPlaylist.Location = new System.Drawing.Point(6, 10);
            this._lsvPlaylist.Name = "_lsvPlaylist";
            this._lsvPlaylist.OwnerDraw = true;
            this._lsvPlaylist.Size = new System.Drawing.Size(367, 107);
            this._lsvPlaylist.TabIndex = 1;
            this._lsvPlaylist.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._lsvPlaylist.UseCompatibleStateImageBehavior = false;
            this._lsvPlaylist.UseSelectable = true;
            this._lsvPlaylist.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._lsvPlaylist);
            this.groupBox1.Controls.Add(this._btnPrevious);
            this.groupBox1.Controls.Add(this._btnNext);
            this.groupBox1.Controls.Add(this._btnShuffle);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(23, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(21, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 10);
            this.panel2.TabIndex = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 318);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Current Session";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 497);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnStop);
            this.Controls.Add(this._pbWalkingGuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._lblTitle);
            this.Controls.Add(this._cboSessions);
            this.Controls.Add(this._btnPlay);
            this.Controls.Add(this._lblTimer);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ARTPOP";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pbWalkingGuy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _lblStatus;
        private MetroFramework.Controls.MetroButton _btnSettings;
        private MetroFramework.Controls.MetroButton _btnPlay;
        private MetroFramework.Controls.MetroButton _btnSession;
        private MetroFramework.Controls.MetroComboBox _cboSessions;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox _pbWalkingGuy;
        private MetroFramework.Controls.MetroButton _btnStop;
        private System.Windows.Forms.Label _lblTimer;
        private MetroFramework.Controls.MetroLabel _lblTitle;
        private MetroFramework.Controls.MetroButton _btnShuffle;
        private MetroFramework.Controls.MetroButton _btnNext;
        private MetroFramework.Controls.MetroButton _btnPrevious;
        private MetroFramework.Controls.MetroListView _lsvPlaylist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

