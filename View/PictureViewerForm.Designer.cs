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
            this._btnRestore = new MetroFramework.Controls.MetroButton();
            this._btnPrevious = new MetroFramework.Controls.MetroButton();
            this._btnNext = new MetroFramework.Controls.MetroButton();
            this._btnPlay = new MetroFramework.Controls.MetroButton();
            this._lblTimer = new System.Windows.Forms.Label();
            this._pbImage = new System.Windows.Forms.PictureBox();
            this._txtInstructions = new System.Windows.Forms.TextBox();
            this._pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnlDetails
            // 
            this._pnlDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this._pnlDetails.Size = new System.Drawing.Size(783, 41);
            this._pnlDetails.TabIndex = 1;
            this._pnlDetails.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._pnlDetails.VerticalScrollbarBarColor = true;
            this._pnlDetails.VerticalScrollbarHighlightOnWheel = false;
            this._pnlDetails.VerticalScrollbarSize = 10;
            // 
            // _btnRestore
            // 
            this._btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnRestore.BackgroundImage = global::ArtPop.Properties.Resources.appbar_window_restore;
            this._btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnRestore.Location = new System.Drawing.Point(724, 8);
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
            this._lblTimer.Location = new System.Drawing.Point(347, 0);
            this._lblTimer.Name = "_lblTimer";
            this._lblTimer.Size = new System.Drawing.Size(91, 36);
            this._lblTimer.TabIndex = 3;
            this._lblTimer.Text = "0:0:0000";
            // 
            // _pbImage
            // 
            this._pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pbImage.Location = new System.Drawing.Point(7, 33);
            this._pbImage.Name = "_pbImage";
            this._pbImage.Size = new System.Drawing.Size(783, 484);
            this._pbImage.TabIndex = 0;
            this._pbImage.TabStop = false;
            this._pbImage.Click += new System.EventHandler(this._pbImage_Click);
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
            this._txtInstructions.Text = "Draw The Face Only";
            this._txtInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PictureViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
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
    }
}