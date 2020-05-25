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
            this._chkTakeABreak = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this._lblRepeat = new MetroFramework.Controls.MetroLabel();
            this._nudRepeat = new System.Windows.Forms.NumericUpDown();
            this._lblRepeat2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnApply
            // 
            this._btnApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnApply.Location = new System.Drawing.Point(116, 441);
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
            this._btnCancel.Location = new System.Drawing.Point(205, 441);
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
            this._btnOk.Location = new System.Drawing.Point(27, 441);
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
            this._txtName.CustomButton.Location = new System.Drawing.Point(241, 1);
            this._txtName.CustomButton.Name = "";
            this._txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtName.CustomButton.TabIndex = 1;
            this._txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this._txtName.Size = new System.Drawing.Size(263, 23);
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
            this._txtInstruction.CustomButton.Location = new System.Drawing.Point(241, 1);
            this._txtInstruction.CustomButton.Name = "";
            this._txtInstruction.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtInstruction.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtInstruction.CustomButton.TabIndex = 1;
            this._txtInstruction.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this._txtInstruction.Size = new System.Drawing.Size(263, 23);
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
            this._cboDifficulty.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._cboDifficulty.UseSelectable = true;
            this._cboDifficulty.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // _chkTakeABreak
            // 
            this._chkTakeABreak.AutoSize = true;
            this._chkTakeABreak.Location = new System.Drawing.Point(10, 20);
            this._chkTakeABreak.Name = "_chkTakeABreak";
            this._chkTakeABreak.Size = new System.Drawing.Size(99, 15);
            this._chkTakeABreak.TabIndex = 12;
            this._chkTakeABreak.Text = "This is a break.";
            this._chkTakeABreak.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkTakeABreak.UseSelectable = true;
            this._chkTakeABreak.CheckedChanged += new System.EventHandler(this._chkTakeABreak_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._lblRepeat2);
            this.groupBox1.Controls.Add(this._nudRepeat);
            this.groupBox1.Controls.Add(this._lblRepeat);
            this.groupBox1.Controls.Add(this._chkTakeABreak);
            this.groupBox1.Location = new System.Drawing.Point(36, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 89);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 320);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Options";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblRepeat
            // 
            this._lblRepeat.AutoSize = true;
            this._lblRepeat.Location = new System.Drawing.Point(6, 47);
            this._lblRepeat.Name = "_lblRepeat";
            this._lblRepeat.Size = new System.Drawing.Size(50, 19);
            this._lblRepeat.TabIndex = 14;
            this._lblRepeat.Text = "Repeat";
            this._lblRepeat.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _nudRepeat
            // 
            this._nudRepeat.Location = new System.Drawing.Point(57, 47);
            this._nudRepeat.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this._nudRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudRepeat.Name = "_nudRepeat";
            this._nudRepeat.Size = new System.Drawing.Size(64, 20);
            this._nudRepeat.TabIndex = 15;
            this._nudRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _lblRepeat2
            // 
            this._lblRepeat2.AutoSize = true;
            this._lblRepeat2.Location = new System.Drawing.Point(124, 47);
            this._lblRepeat2.Name = "_lblRepeat2";
            this._lblRepeat2.Size = new System.Drawing.Size(43, 19);
            this._lblRepeat2.TabIndex = 16;
            this._lblRepeat2.Text = "times.";
            this._lblRepeat2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ExerciseEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 489);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "ExerciseEditorForm";
            this.Text = "Edit Exercise";
            this.Load += new System.EventHandler(this.ExerciseEditorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudRepeat)).EndInit();
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
        private MetroFramework.Controls.MetroCheckBox _chkTakeABreak;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown _nudRepeat;
        private MetroFramework.Controls.MetroLabel _lblRepeat;
        private MetroFramework.Controls.MetroLabel _lblRepeat2;
    }
}