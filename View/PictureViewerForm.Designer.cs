namespace ArtPop
{
    partial class PictureViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureViewerForm));
            this._pnlDetails = new MetroFramework.Controls.MetroPanel();
            this._btnRestore_Fullscreen = new MetroFramework.Controls.MetroButton();
            this._btnRestore = new MetroFramework.Controls.MetroButton();
            this._btnPrevious = new MetroFramework.Controls.MetroButton();
            this._btnNext = new MetroFramework.Controls.MetroButton();
            this._btnPlay = new MetroFramework.Controls.MetroButton();
            this._lblTimer = new System.Windows.Forms.Label();
            this._txtInstructions = new System.Windows.Forms.TextBox();
            this._pnlPie = new MetroFramework.Controls.MetroPanel();
            this._txtMessage = new System.Windows.Forms.TextBox();
            this._pbImage = new System.Windows.Forms.PictureBox();
            this._btnFavorite = new System.Windows.Forms.PictureBox();
            this._pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._btnFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnlDetails
            // 
            this._pnlDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlDetails.Controls.Add(this._btnRestore_Fullscreen);
            this._pnlDetails.Controls.Add(this._btnRestore);
            this._pnlDetails.Controls.Add(this._btnPrevious);
            this._pnlDetails.Controls.Add(this._btnNext);
            this._pnlDetails.Controls.Add(this._btnPlay);
            this._pnlDetails.Controls.Add(this._lblTimer);
            this._pnlDetails.HorizontalScrollbarBarColor = true;
            this._pnlDetails.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlDetails.HorizontalScrollbarSize = 10;
            this._pnlDetails.Location = new System.Drawing.Point(7, 558);
            this._pnlDetails.Name = "_pnlDetails";
            this._pnlDetails.Size = new System.Drawing.Size(757, 41);
            this._pnlDetails.TabIndex = 1;
            this._pnlDetails.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._pnlDetails.VerticalScrollbarBarColor = true;
            this._pnlDetails.VerticalScrollbarHighlightOnWheel = false;
            this._pnlDetails.VerticalScrollbarSize = 10;
            // 
            // _btnRestore_Fullscreen
            // 
            this._btnRestore_Fullscreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnRestore_Fullscreen.BackgroundImage = global::ArtPop.Properties.Resources.appbar_window_restore;
            this._btnRestore_Fullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnRestore_Fullscreen.Location = new System.Drawing.Point(-33, 20);
            this._btnRestore_Fullscreen.Name = "_btnRestore_Fullscreen";
            this._btnRestore_Fullscreen.Size = new System.Drawing.Size(29, 26);
            this._btnRestore_Fullscreen.TabIndex = 6;
            this._btnRestore_Fullscreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnRestore_Fullscreen.UseSelectable = true;
            this._btnRestore_Fullscreen.Visible = false;
            this._btnRestore_Fullscreen.Click += new System.EventHandler(this._btnRestore_Fullscreen_Click);
            // 
            // _btnRestore
            // 
            this._btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnRestore.BackgroundImage = global::ArtPop.Properties.Resources.appbar_window_restore;
            this._btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnRestore.Location = new System.Drawing.Point(704, 9);
            this._btnRestore.Name = "_btnRestore";
            this._btnRestore.Size = new System.Drawing.Size(45, 26);
            this._btnRestore.TabIndex = 5;
            this._btnRestore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnRestore.UseSelectable = true;
            this._btnRestore.Click += new System.EventHandler(this._btnRestore_Click);
            // 
            // _btnPrevious
            // 
            this._btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnPrevious.BackgroundImage = global::ArtPop.Properties.Resources.appbar_navigate_previous;
            this._btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnPrevious.Location = new System.Drawing.Point(61, 8);
            this._btnPrevious.Name = "_btnPrevious";
            this._btnPrevious.Size = new System.Drawing.Size(31, 26);
            this._btnPrevious.TabIndex = 5;
            this._btnPrevious.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnPrevious.UseSelectable = true;
            this._btnPrevious.Click += new System.EventHandler(this._btnPrevious_Click);
            // 
            // _btnNext
            // 
            this._btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnNext.BackgroundImage = global::ArtPop.Properties.Resources.appbar_navigate_next;
            this._btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnNext.Location = new System.Drawing.Point(98, 8);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(31, 26);
            this._btnNext.TabIndex = 5;
            this._btnNext.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnNext.UseSelectable = true;
            this._btnNext.Click += new System.EventHandler(this._btnNext_Click);
            // 
            // _btnPlay
            // 
            this._btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnPlay.BackgroundImage = global::ArtPop.Properties.Resources.appbar_timer_play;
            this._btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnPlay.Location = new System.Drawing.Point(10, 8);
            this._btnPlay.Name = "_btnPlay";
            this._btnPlay.Size = new System.Drawing.Size(31, 26);
            this._btnPlay.TabIndex = 5;
            this._btnPlay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnPlay.UseSelectable = true;
            this._btnPlay.Click += new System.EventHandler(this._btnPlay_Click);
            // 
            // _lblTimer
            // 
            this._lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._lblTimer.AutoSize = true;
            this._lblTimer.Font = new System.Drawing.Font("Adobe Caslon Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTimer.ForeColor = System.Drawing.Color.DimGray;
            this._lblTimer.Location = new System.Drawing.Point(334, 0);
            this._lblTimer.Name = "_lblTimer";
            this._lblTimer.Size = new System.Drawing.Size(91, 36);
            this._lblTimer.TabIndex = 3;
            this._lblTimer.Text = "0:0:0000";
            // 
            // _txtInstructions
            // 
            this._txtInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtInstructions.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtInstructions.ForeColor = System.Drawing.Color.Gray;
            this._txtInstructions.Location = new System.Drawing.Point(7, 513);
            this._txtInstructions.Name = "_txtInstructions";
            this._txtInstructions.Size = new System.Drawing.Size(783, 32);
            this._txtInstructions.TabIndex = 2;
            this._txtInstructions.Text = "Instruction";
            this._txtInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _pnlPie
            // 
            this._pnlPie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlPie.HorizontalScrollbarBarColor = true;
            this._pnlPie.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlPie.HorizontalScrollbarSize = 10;
            this._pnlPie.Location = new System.Drawing.Point(769, 559);
            this._pnlPie.Name = "_pnlPie";
            this._pnlPie.Size = new System.Drawing.Size(25, 25);
            this._pnlPie.TabIndex = 3;
            this._pnlPie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._pnlPie.VerticalScrollbarBarColor = true;
            this._pnlPie.VerticalScrollbarHighlightOnWheel = false;
            this._pnlPie.VerticalScrollbarSize = 10;
            this._pnlPie.CustomPaint += new System.EventHandler<MetroFramework.Drawing.MetroPaintEventArgs>(this._pnlPie_CustomPaint);
            // 
            // _txtMessage
            // 
            this._txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtMessage.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtMessage.ForeColor = System.Drawing.Color.Gray;
            this._txtMessage.Location = new System.Drawing.Point(7, 44);
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.Size = new System.Drawing.Size(783, 32);
            this._txtMessage.TabIndex = 4;
            this._txtMessage.Text = "Message";
            this._txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtMessage.Visible = false;
            // 
            // _pbImage
            // 
            this._pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pbImage.Location = new System.Drawing.Point(-2, 33);
            this._pbImage.Name = "_pbImage";
            this._pbImage.Size = new System.Drawing.Size(804, 484);
            this._pbImage.TabIndex = 0;
            this._pbImage.TabStop = false;
            this._pbImage.Click += new System.EventHandler(this._pbImage_Click);
            // 
            // _btnFavorite
            // 
            this._btnFavorite.Image = ((System.Drawing.Image)(resources.GetObject("_btnFavorite.Image")));
            this._btnFavorite.Location = new System.Drawing.Point(4, 9);
            this._btnFavorite.Name = "_btnFavorite";
            this._btnFavorite.Size = new System.Drawing.Size(33, 33);
            this._btnFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._btnFavorite.TabIndex = 5;
            this._btnFavorite.TabStop = false;
            this._btnFavorite.Click += new System.EventHandler(this._btnFavorite_Click);
            // 
            // PictureViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this._btnFavorite);
            this.Controls.Add(this._txtMessage);
            this.Controls.Add(this._pnlPie);
            this.Controls.Add(this._txtInstructions);
            this.Controls.Add(this._pnlDetails);
            this.Controls.Add(this._pbImage);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureViewerForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShowIcon = false;
            this.Text = "PictureViewer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureViewerForm_FormClosing);
            this.Load += new System.EventHandler(this.PictureViewer_Load);
            this.Shown += new System.EventHandler(this.PictureViewerForm_Shown);
            this._pnlDetails.ResumeLayout(false);
            this._pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._btnFavorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _pbImage;
        private MetroFramework.Controls.MetroPanel _pnlDetails;
        private System.Windows.Forms.Label _lblTimer;
        private MetroFramework.Controls.MetroButton _btnPlay;
        private MetroFramework.Controls.MetroButton _btnRestore;
        private MetroFramework.Controls.MetroButton _btnPrevious;
        private MetroFramework.Controls.MetroButton _btnNext;
        private System.Windows.Forms.TextBox _txtInstructions;
        private MetroFramework.Controls.MetroButton _btnRestore_Fullscreen;
        private MetroFramework.Controls.MetroPanel _pnlPie;
        private System.Windows.Forms.TextBox _txtMessage;
        private System.Windows.Forms.PictureBox _btnFavorite;
    }
}