namespace ArtPop
{
    partial class ArtPopNumericUpDown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._txtValue = new MetroFramework.Controls.MetroTextBox();
            this._btnUp = new MetroFramework.Controls.MetroButton();
            this._btnDown = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // _txtValue
            // 
            this._txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtValue.CustomButton.Image = null;
            this._txtValue.CustomButton.Location = new System.Drawing.Point(90, 1);
            this._txtValue.CustomButton.Name = "";
            this._txtValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtValue.CustomButton.TabIndex = 1;
            this._txtValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtValue.CustomButton.UseSelectable = true;
            this._txtValue.CustomButton.Visible = false;
            this._txtValue.Lines = new string[] {
        "metroTextBox1"};
            this._txtValue.Location = new System.Drawing.Point(1, 0);
            this._txtValue.MaxLength = 32767;
            this._txtValue.Name = "_txtValue";
            this._txtValue.PasswordChar = '\0';
            this._txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtValue.SelectedText = "";
            this._txtValue.SelectionLength = 0;
            this._txtValue.SelectionStart = 0;
            this._txtValue.ShortcutsEnabled = true;
            this._txtValue.Size = new System.Drawing.Size(114, 23);
            this._txtValue.TabIndex = 0;
            this._txtValue.Text = "metroTextBox1";
            this._txtValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtValue.UseSelectable = true;
            this._txtValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtValue.TextChanged += new System.EventHandler(this._txtValue_TextChanged);
            this._txtValue.Click += new System.EventHandler(this._txtValue_Click);
            this._txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtValue_KeyPress);
            // 
            // _btnUp
            // 
            this._btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnUp.BackColor = System.Drawing.Color.Transparent;
            this._btnUp.BackgroundImage = global::ArtPop.Properties.Resources.appbar_chevron_up;
            this._btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnUp.Location = new System.Drawing.Point(114, 0);
            this._btnUp.Name = "_btnUp";
            this._btnUp.Size = new System.Drawing.Size(16, 14);
            this._btnUp.TabIndex = 1;
            this._btnUp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnUp.UseSelectable = true;
            this._btnUp.Click += new System.EventHandler(this._btnUp_Click);
            // 
            // _btnDown
            // 
            this._btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDown.BackColor = System.Drawing.Color.Transparent;
            this._btnDown.BackgroundImage = global::ArtPop.Properties.Resources.appbar_chevron_down;
            this._btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnDown.Location = new System.Drawing.Point(114, 10);
            this._btnDown.Name = "_btnDown";
            this._btnDown.Size = new System.Drawing.Size(16, 14);
            this._btnDown.TabIndex = 1;
            this._btnDown.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnDown.UseSelectable = true;
            this._btnDown.Click += new System.EventHandler(this._btnDown_Click);
            // 
            // ArtPopNumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnDown);
            this.Controls.Add(this._btnUp);
            this.Controls.Add(this._txtValue);
            this.Name = "ArtPopNumericUpDown";
            this.Size = new System.Drawing.Size(130, 24);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MonoEditNumericUpDown_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox _txtValue;
        private MetroFramework.Controls.MetroButton _btnUp;
        private MetroFramework.Controls.MetroButton _btnDown;
    }
}
