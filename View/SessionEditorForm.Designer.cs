namespace ArtPop
{
    partial class SessionEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionEditorForm));
            this._cboSessionList = new MetroFramework.Controls.MetroComboBox();
            this._txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._btnNewSession = new MetroFramework.Controls.MetroButton();
            this._btnOk = new MetroFramework.Controls.MetroButton();
            this._btnCancel = new MetroFramework.Controls.MetroButton();
            this._lsvSessionExercises = new MetroFramework.Controls.MetroListView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this._lsvConfiguredExercises = new MetroFramework.Controls.MetroListView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this._btnDeleteSessionExercise = new MetroFramework.Controls.MetroButton();
            this._btnMoveExerciseDown = new MetroFramework.Controls.MetroButton();
            this._btnRemoveConfiguredExercise = new MetroFramework.Controls.MetroButton();
            this._btnEditConfiguredExercise = new MetroFramework.Controls.MetroButton();
            this._btnAddConfiguredExercise = new MetroFramework.Controls.MetroButton();
            this._btnMoveLeft = new MetroFramework.Controls.MetroButton();
            this._btnMoveExerciseUp = new MetroFramework.Controls.MetroButton();
            this._btnDeleteSession = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this._lblSessionDuration = new MetroFramework.Controls.MetroLabel();
            this._pnlSessionStats = new MetroFramework.Controls.MetroPanel();
            this._pnlSessionStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cboSessionList
            // 
            this._cboSessionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cboSessionList.FormattingEnabled = true;
            this._cboSessionList.ItemHeight = 23;
            this._cboSessionList.Location = new System.Drawing.Point(37, 78);
            this._cboSessionList.Name = "_cboSessionList";
            this._cboSessionList.Size = new System.Drawing.Size(287, 29);
            this._cboSessionList.TabIndex = 0;
            this._cboSessionList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._cboSessionList.UseSelectable = true;
            this._cboSessionList.SelectedIndexChanged += new System.EventHandler(this._cboSessionList_SelectedIndexChanged);
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtName.CustomButton.Image = null;
            this._txtName.CustomButton.Location = new System.Drawing.Point(265, 1);
            this._txtName.CustomButton.Name = "";
            this._txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtName.CustomButton.TabIndex = 1;
            this._txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtName.CustomButton.UseSelectable = true;
            this._txtName.CustomButton.Visible = false;
            this._txtName.Lines = new string[] {
        "MyPracticeSession"};
            this._txtName.Location = new System.Drawing.Point(76, 132);
            this._txtName.MaxLength = 32767;
            this._txtName.Name = "_txtName";
            this._txtName.PasswordChar = '\0';
            this._txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtName.SelectedText = "";
            this._txtName.SelectionLength = 0;
            this._txtName.SelectionStart = 0;
            this._txtName.ShortcutsEnabled = true;
            this._txtName.Size = new System.Drawing.Size(287, 23);
            this._txtName.TabIndex = 1;
            this._txtName.Text = "MyPracticeSession";
            this._txtName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtName.UseSelectable = true;
            this._txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtName.TextChanged += new System.EventHandler(this._txtName_TextChanged);
            this._txtName.Click += new System.EventHandler(this._txtName_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 132);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Select Session";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _btnNewSession
            // 
            this._btnNewSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnNewSession.BackgroundImage = global::ArtPop.Properties.Resources.appbar_page_add;
            this._btnNewSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnNewSession.Location = new System.Drawing.Point(330, 78);
            this._btnNewSession.Name = "_btnNewSession";
            this._btnNewSession.Size = new System.Drawing.Size(37, 29);
            this._btnNewSession.TabIndex = 4;
            this._btnNewSession.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnNewSession.UseSelectable = true;
            this._btnNewSession.Click += new System.EventHandler(this._btnNewSession_Click);
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnOk.Location = new System.Drawing.Point(124, 506);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(83, 25);
            this._btnOk.TabIndex = 4;
            this._btnOk.Text = "Ok";
            this._btnOk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnOk.UseSelectable = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnCancel.Location = new System.Drawing.Point(213, 506);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(83, 25);
            this._btnCancel.TabIndex = 4;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnCancel.UseSelectable = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _lsvSessionExercises
            // 
            this._lsvSessionExercises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsvSessionExercises.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._lsvSessionExercises.FullRowSelect = true;
            this._lsvSessionExercises.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._lsvSessionExercises.LabelWrap = false;
            this._lsvSessionExercises.Location = new System.Drawing.Point(57, 243);
            this._lsvSessionExercises.Name = "_lsvSessionExercises";
            this._lsvSessionExercises.OwnerDraw = true;
            this._lsvSessionExercises.ShowGroups = false;
            this._lsvSessionExercises.Size = new System.Drawing.Size(138, 199);
            this._lsvSessionExercises.TabIndex = 5;
            this._lsvSessionExercises.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._lsvSessionExercises.UseCompatibleStateImageBehavior = false;
            this._lsvSessionExercises.UseSelectable = true;
            this._lsvSessionExercises.View = System.Windows.Forms.View.List;
            this._lsvSessionExercises.SelectedIndexChanged += new System.EventHandler(this._lsvSessionExercises_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 193);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(195, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Click \"+\" to Add a new Exercise.";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(57, 221);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Session Exercises";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lsvConfiguredExercises
            // 
            this._lsvConfiguredExercises.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsvConfiguredExercises.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._lsvConfiguredExercises.FullRowSelect = true;
            this._lsvConfiguredExercises.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._lsvConfiguredExercises.LabelWrap = false;
            this._lsvConfiguredExercises.Location = new System.Drawing.Point(237, 243);
            this._lsvConfiguredExercises.Name = "_lsvConfiguredExercises";
            this._lsvConfiguredExercises.OwnerDraw = true;
            this._lsvConfiguredExercises.ShowGroups = false;
            this._lsvConfiguredExercises.Size = new System.Drawing.Size(145, 199);
            this._lsvConfiguredExercises.TabIndex = 5;
            this._lsvConfiguredExercises.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._lsvConfiguredExercises.UseCompatibleStateImageBehavior = false;
            this._lsvConfiguredExercises.UseSelectable = true;
            this._lsvConfiguredExercises.View = System.Windows.Forms.View.List;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(237, 221);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(130, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Configured Exercises";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _btnDeleteSessionExercise
            // 
            this._btnDeleteSessionExercise.BackgroundImage = global::ArtPop.Properties.Resources.appbar_delete;
            this._btnDeleteSessionExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnDeleteSessionExercise.Location = new System.Drawing.Point(23, 365);
            this._btnDeleteSessionExercise.Name = "_btnDeleteSessionExercise";
            this._btnDeleteSessionExercise.Size = new System.Drawing.Size(28, 29);
            this._btnDeleteSessionExercise.TabIndex = 4;
            this._btnDeleteSessionExercise.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnDeleteSessionExercise.UseSelectable = true;
            this._btnDeleteSessionExercise.Click += new System.EventHandler(this._btnDeleteSessionExercise_Click);
            // 
            // _btnMoveExerciseDown
            // 
            this._btnMoveExerciseDown.BackgroundImage = global::ArtPop.Properties.Resources.appbar_cell_down;
            this._btnMoveExerciseDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnMoveExerciseDown.Location = new System.Drawing.Point(23, 330);
            this._btnMoveExerciseDown.Name = "_btnMoveExerciseDown";
            this._btnMoveExerciseDown.Size = new System.Drawing.Size(28, 29);
            this._btnMoveExerciseDown.TabIndex = 4;
            this._btnMoveExerciseDown.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnMoveExerciseDown.UseSelectable = true;
            this._btnMoveExerciseDown.Click += new System.EventHandler(this._btnMoveExerciseDown_Click);
            // 
            // _btnRemoveConfiguredExercise
            // 
            this._btnRemoveConfiguredExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRemoveConfiguredExercise.BackgroundImage = global::ArtPop.Properties.Resources.appbar_delete;
            this._btnRemoveConfiguredExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnRemoveConfiguredExercise.Location = new System.Drawing.Point(388, 313);
            this._btnRemoveConfiguredExercise.Name = "_btnRemoveConfiguredExercise";
            this._btnRemoveConfiguredExercise.Size = new System.Drawing.Size(28, 29);
            this._btnRemoveConfiguredExercise.TabIndex = 4;
            this._btnRemoveConfiguredExercise.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnRemoveConfiguredExercise.UseSelectable = true;
            this._btnRemoveConfiguredExercise.Click += new System.EventHandler(this._btnRemoveConfiguredExercise_Click);
            // 
            // _btnEditConfiguredExercise
            // 
            this._btnEditConfiguredExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEditConfiguredExercise.BackgroundImage = global::ArtPop.Properties.Resources.appbar_edit;
            this._btnEditConfiguredExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnEditConfiguredExercise.Location = new System.Drawing.Point(388, 278);
            this._btnEditConfiguredExercise.Name = "_btnEditConfiguredExercise";
            this._btnEditConfiguredExercise.Size = new System.Drawing.Size(28, 29);
            this._btnEditConfiguredExercise.TabIndex = 4;
            this._btnEditConfiguredExercise.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnEditConfiguredExercise.UseSelectable = true;
            this._btnEditConfiguredExercise.Click += new System.EventHandler(this._btnEditConfiguredExercise_Click);
            // 
            // _btnAddConfiguredExercise
            // 
            this._btnAddConfiguredExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAddConfiguredExercise.BackgroundImage = global::ArtPop.Properties.Resources.appbar_add;
            this._btnAddConfiguredExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnAddConfiguredExercise.Location = new System.Drawing.Point(388, 243);
            this._btnAddConfiguredExercise.Name = "_btnAddConfiguredExercise";
            this._btnAddConfiguredExercise.Size = new System.Drawing.Size(28, 29);
            this._btnAddConfiguredExercise.TabIndex = 4;
            this._btnAddConfiguredExercise.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnAddConfiguredExercise.UseSelectable = true;
            this._btnAddConfiguredExercise.Click += new System.EventHandler(this._btnAddConfiguredExercise_Click);
            // 
            // _btnMoveLeft
            // 
            this._btnMoveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnMoveLeft.BackgroundImage = global::ArtPop.Properties.Resources.appbar_arrow_left;
            this._btnMoveLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnMoveLeft.Location = new System.Drawing.Point(203, 330);
            this._btnMoveLeft.Name = "_btnMoveLeft";
            this._btnMoveLeft.Size = new System.Drawing.Size(28, 29);
            this._btnMoveLeft.TabIndex = 4;
            this._btnMoveLeft.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnMoveLeft.UseSelectable = true;
            this._btnMoveLeft.Click += new System.EventHandler(this._btnMoveLeft_Click);
            // 
            // _btnMoveExerciseUp
            // 
            this._btnMoveExerciseUp.BackgroundImage = global::ArtPop.Properties.Resources.appbar_cell_up;
            this._btnMoveExerciseUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnMoveExerciseUp.Location = new System.Drawing.Point(23, 295);
            this._btnMoveExerciseUp.Name = "_btnMoveExerciseUp";
            this._btnMoveExerciseUp.Size = new System.Drawing.Size(28, 29);
            this._btnMoveExerciseUp.TabIndex = 4;
            this._btnMoveExerciseUp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnMoveExerciseUp.UseSelectable = true;
            this._btnMoveExerciseUp.Click += new System.EventHandler(this._btnMoveExerciseUp_Click);
            // 
            // _btnDeleteSession
            // 
            this._btnDeleteSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDeleteSession.BackgroundImage = global::ArtPop.Properties.Resources.appbar_page_delete;
            this._btnDeleteSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnDeleteSession.Location = new System.Drawing.Point(373, 78);
            this._btnDeleteSession.Name = "_btnDeleteSession";
            this._btnDeleteSession.Size = new System.Drawing.Size(36, 29);
            this._btnDeleteSession.TabIndex = 4;
            this._btnDeleteSession.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnDeleteSession.UseSelectable = true;
            this._btnDeleteSession.Click += new System.EventHandler(this._btnDeleteSession_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Session Duration:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblSessionDuration
            // 
            this._lblSessionDuration.AutoSize = true;
            this._lblSessionDuration.Location = new System.Drawing.Point(117, 0);
            this._lblSessionDuration.Name = "_lblSessionDuration";
            this._lblSessionDuration.Size = new System.Drawing.Size(187, 19);
            this._lblSessionDuration.TabIndex = 6;
            this._lblSessionDuration.Text = "0 Hours 10 Minutes 10 Seconds";
            this._lblSessionDuration.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _pnlSessionStats
            // 
            this._pnlSessionStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlSessionStats.Controls.Add(this._lblSessionDuration);
            this._pnlSessionStats.Controls.Add(this.metroLabel6);
            this._pnlSessionStats.HorizontalScrollbarBarColor = true;
            this._pnlSessionStats.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlSessionStats.HorizontalScrollbarSize = 10;
            this._pnlSessionStats.Location = new System.Drawing.Point(23, 462);
            this._pnlSessionStats.Name = "_pnlSessionStats";
            this._pnlSessionStats.Size = new System.Drawing.Size(385, 38);
            this._pnlSessionStats.TabIndex = 7;
            this._pnlSessionStats.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._pnlSessionStats.VerticalScrollbarBarColor = true;
            this._pnlSessionStats.VerticalScrollbarHighlightOnWheel = false;
            this._pnlSessionStats.VerticalScrollbarSize = 10;
            // 
            // SessionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 554);
            this.Controls.Add(this._pnlSessionStats);
            this.Controls.Add(this._lsvConfiguredExercises);
            this.Controls.Add(this._lsvSessionExercises);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._btnDeleteSessionExercise);
            this.Controls.Add(this._btnMoveExerciseDown);
            this.Controls.Add(this._btnRemoveConfiguredExercise);
            this.Controls.Add(this._btnEditConfiguredExercise);
            this.Controls.Add(this._btnAddConfiguredExercise);
            this.Controls.Add(this._btnMoveLeft);
            this.Controls.Add(this._btnMoveExerciseUp);
            this.Controls.Add(this._btnDeleteSession);
            this.Controls.Add(this._btnNewSession);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._cboSessionList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SessionEditorForm";
            this.Text = "Practice Session Editor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SessionEditorForm_Load);
            this._pnlSessionStats.ResumeLayout(false);
            this._pnlSessionStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox _cboSessionList;
        private MetroFramework.Controls.MetroTextBox _txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton _btnNewSession;
        private MetroFramework.Controls.MetroButton _btnOk;
        private MetroFramework.Controls.MetroButton _btnCancel;
        private MetroFramework.Controls.MetroListView _lsvSessionExercises;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton _btnMoveExerciseUp;
        private MetroFramework.Controls.MetroButton _btnMoveExerciseDown;
        private MetroFramework.Controls.MetroListView _lsvConfiguredExercises;
        private MetroFramework.Controls.MetroButton _btnMoveLeft;
        private MetroFramework.Controls.MetroButton _btnDeleteSessionExercise;
        private MetroFramework.Controls.MetroButton _btnAddConfiguredExercise;
        private MetroFramework.Controls.MetroButton _btnEditConfiguredExercise;
        private MetroFramework.Controls.MetroButton _btnRemoveConfiguredExercise;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton _btnDeleteSession;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel _lblSessionDuration;
        private MetroFramework.Controls.MetroPanel _pnlSessionStats;
    }
}