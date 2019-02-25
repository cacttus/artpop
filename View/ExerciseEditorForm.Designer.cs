namespace ArtPop
{
    partial class ExerciseEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseEditorForm));
            this._btnApply = new MetroFramework.Controls.MetroButton();
            this._btnCancel = new MetroFramework.Controls.MetroButton();
            this._btnOk = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this._txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._txtInstruction = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this._dtpTime = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this._cboDifficulty = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // _btnApply
            // 
            this._btnApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnApply.Location = new System.Drawing.Point(118, 348);
            this._btnApply.Name = "_btnApply";
            this._btnApply.Size = new System.Drawing.Size(83, 25);
            this._btnApply.TabIndex = 5;
            this._btnApply.Text = "Apply";
            this._btnApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnApply.UseSelectable = true;
            this._btnApply.Click += new System.EventHandler(this._btnApply_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnCancel.Location = new System.Drawing.Point(207, 348);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(83, 25);
            this._btnCancel.TabIndex = 6;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnCancel.UseSelectable = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnOk.Location = new System.Drawing.Point(29, 348);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(83, 25);
            this._btnOk.TabIndex = 7;
            this._btnOk.Text = "Ok";
            this._btnOk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnOk.UseSelectable = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Exercise Name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtName.CustomButton.Image = null;
            this._txtName.CustomButton.Location = new System.Drawing.Point(245, 1);
            this._txtName.CustomButton.Name = "";
            this._txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtName.CustomButton.TabIndex = 1;
            this._txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtName.CustomButton.UseSelectable = true;
            this._txtName.CustomButton.Visible = false;
            this._txtName.Lines = new string[] {
        "MyExercise"};
            this._txtName.Location = new System.Drawing.Point(36, 82);
            this._txtName.MaxLength = 32767;
            this._txtName.Name = "_txtName";
            this._txtName.PasswordChar = '\0';
            this._txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtName.SelectedText = "";
            this._txtName.SelectionLength = 0;
            this._txtName.SelectionStart = 0;
            this._txtName.ShortcutsEnabled = true;
            this._txtName.Size = new System.Drawing.Size(267, 23);
            this._txtName.TabIndex = 8;
            this._txtName.Text = "MyExercise";
            this._txtName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtName.UseSelectable = true;
            this._txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtName.TextChanged += new System.EventHandler(this._txtName_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(131, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Instruction (Optional)";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _txtInstruction
            // 
            this._txtInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtInstruction.CustomButton.Image = null;
            this._txtInstruction.CustomButton.Location = new System.Drawing.Point(245, 1);
            this._txtInstruction.CustomButton.Name = "";
            this._txtInstruction.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtInstruction.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtInstruction.CustomButton.TabIndex = 1;
            this._txtInstruction.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtInstruction.CustomButton.UseSelectable = true;
            this._txtInstruction.CustomButton.Visible = false;
            this._txtInstruction.Lines = new string[] {
        "Draw Face Only"};
            this._txtInstruction.Location = new System.Drawing.Point(36, 146);
            this._txtInstruction.MaxLength = 32767;
            this._txtInstruction.Name = "_txtInstruction";
            this._txtInstruction.PasswordChar = '\0';
            this._txtInstruction.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtInstruction.SelectedText = "";
            this._txtInstruction.SelectionLength = 0;
            this._txtInstruction.SelectionStart = 0;
            this._txtInstruction.ShortcutsEnabled = true;
            this._txtInstruction.Size = new System.Drawing.Size(267, 23);
            this._txtInstruction.TabIndex = 8;
            this._txtInstruction.Text = "Draw Face Only";
            this._txtInstruction.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtInstruction.UseSelectable = true;
            this._txtInstruction.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtInstruction.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtInstruction.TextChanged += new System.EventHandler(this._txtInstruction_TextChanged);
            this._txtInstruction.Click += new System.EventHandler(this._txtInstruction_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 187);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Duration";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _dtpTime
            // 
            this._dtpTime.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this._dtpTime.CalendarMonthBackground = System.Drawing.Color.Silver;
            this._dtpTime.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this._dtpTime.CustomFormat = "HH:mm:ss";
            this._dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpTime.Location = new System.Drawing.Point(36, 209);
            this._dtpTime.Name = "_dtpTime";
            this._dtpTime.ShowUpDown = true;
            this._dtpTime.Size = new System.Drawing.Size(105, 26);
            this._dtpTime.TabIndex = 10;
            this._dtpTime.Value = new System.DateTime(2019, 2, 23, 0, 2, 0, 0);
            this._dtpTime.ValueChanged += new System.EventHandler(this._dtpTime_ValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 254);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Difficulty Level";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _cboDifficulty
            // 
            this._cboDifficulty.FormattingEnabled = true;
            this._cboDifficulty.ItemHeight = 23;
            this._cboDifficulty.Items.AddRange(new object[] {
            "Very Easy",
            "Easy",
            "Normal",
            "Hard",
            "Very Hard"});
            this._cboDifficulty.Location = new System.Drawing.Point(36, 276);
            this._cboDifficulty.Name = "_cboDifficulty";
            this._cboDifficulty.Size = new System.Drawing.Size(186, 29);
            this._cboDifficulty.TabIndex = 11;
            this._cboDifficulty.UseSelectable = true;
            this._cboDifficulty.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // ExerciseEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 396);
            this.Controls.Add(this._cboDifficulty);
            this.Controls.Add(this._dtpTime);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this._txtInstruction);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._btnApply);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExerciseEditorForm";
            this.Text = "Edit Exercise";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ExerciseEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton _btnApply;
        private MetroFramework.Controls.MetroButton _btnCancel;
        private MetroFramework.Controls.MetroButton _btnOk;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox _txtName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox _txtInstruction;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker _dtpTime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox _cboDifficulty;
    }
}