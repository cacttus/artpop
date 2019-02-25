namespace ArtPop
{
    partial class HelpForm
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
            this._txtHelp = new MetroFramework.Controls.MetroTextBox();
            this._btnClose = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this._txtLicense = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this._txtAbout = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtHelp
            // 
            // 
            // 
            // 
            this._txtHelp.CustomButton.Image = null;
            this._txtHelp.CustomButton.Location = new System.Drawing.Point(255, 2);
            this._txtHelp.CustomButton.Name = "";
            this._txtHelp.CustomButton.Size = new System.Drawing.Size(299, 299);
            this._txtHelp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtHelp.CustomButton.TabIndex = 1;
            this._txtHelp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtHelp.CustomButton.UseSelectable = true;
            this._txtHelp.CustomButton.Visible = false;
            this._txtHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtHelp.Lines = new string[0];
            this._txtHelp.Location = new System.Drawing.Point(0, 0);
            this._txtHelp.MaxLength = 32767;
            this._txtHelp.Multiline = true;
            this._txtHelp.Name = "_txtHelp";
            this._txtHelp.PasswordChar = '\0';
            this._txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtHelp.SelectedText = "";
            this._txtHelp.SelectionLength = 0;
            this._txtHelp.SelectionStart = 0;
            this._txtHelp.ShortcutsEnabled = false;
            this._txtHelp.Size = new System.Drawing.Size(557, 304);
            this._txtHelp.TabIndex = 0;
            this._txtHelp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtHelp.UseSelectable = true;
            this._txtHelp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtHelp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnClose.Location = new System.Drawing.Point(257, 385);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 1;
            this._btnClose.Text = "Close";
            this._btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnClose.UseSelectable = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 50);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(565, 329);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this._txtHelp);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(557, 304);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Help";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this._txtLicense);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(557, 304);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "License";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // _txtLicense
            // 
            // 
            // 
            // 
            this._txtLicense.CustomButton.Image = null;
            this._txtLicense.CustomButton.Location = new System.Drawing.Point(255, 2);
            this._txtLicense.CustomButton.Name = "";
            this._txtLicense.CustomButton.Size = new System.Drawing.Size(299, 299);
            this._txtLicense.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtLicense.CustomButton.TabIndex = 1;
            this._txtLicense.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtLicense.CustomButton.UseSelectable = true;
            this._txtLicense.CustomButton.Visible = false;
            this._txtLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtLicense.Lines = new string[0];
            this._txtLicense.Location = new System.Drawing.Point(0, 0);
            this._txtLicense.MaxLength = 32767;
            this._txtLicense.Multiline = true;
            this._txtLicense.Name = "_txtLicense";
            this._txtLicense.PasswordChar = '\0';
            this._txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtLicense.SelectedText = "";
            this._txtLicense.SelectionLength = 0;
            this._txtLicense.SelectionStart = 0;
            this._txtLicense.ShortcutsEnabled = false;
            this._txtLicense.Size = new System.Drawing.Size(557, 304);
            this._txtLicense.TabIndex = 2;
            this._txtLicense.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtLicense.UseSelectable = true;
            this._txtLicense.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtLicense.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this._txtAbout);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(557, 287);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // _txtAbout
            // 
            // 
            // 
            // 
            this._txtAbout.CustomButton.Image = null;
            this._txtAbout.CustomButton.Location = new System.Drawing.Point(255, 2);
            this._txtAbout.CustomButton.Name = "";
            this._txtAbout.CustomButton.Size = new System.Drawing.Size(299, 299);
            this._txtAbout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtAbout.CustomButton.TabIndex = 1;
            this._txtAbout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtAbout.CustomButton.UseSelectable = true;
            this._txtAbout.CustomButton.Visible = false;
            this._txtAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtAbout.Lines = new string[0];
            this._txtAbout.Location = new System.Drawing.Point(0, 0);
            this._txtAbout.MaxLength = 32767;
            this._txtAbout.Multiline = true;
            this._txtAbout.Name = "_txtAbout";
            this._txtAbout.PasswordChar = '\0';
            this._txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtAbout.SelectedText = "";
            this._txtAbout.SelectionLength = 0;
            this._txtAbout.SelectionStart = 0;
            this._txtAbout.ShortcutsEnabled = false;
            this._txtAbout.Size = new System.Drawing.Size(557, 287);
            this._txtAbout.TabIndex = 3;
            this._txtAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtAbout.UseSelectable = true;
            this._txtAbout.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtAbout.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 431);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this._btnClose);
            this.Name = "HelpForm";
            this.Text = "Help && About";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox _txtHelp;
        private MetroFramework.Controls.MetroButton _btnClose;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox _txtLicense;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox _txtAbout;
    }
}