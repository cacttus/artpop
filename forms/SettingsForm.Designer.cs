namespace ArtPop
{
    partial class SettingsForm
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
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("PNG");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("JPG");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("TGA");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("BMP");
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("TIFF");
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("GIF");
            this._btnOk = new MetroFramework.Controls.MetroButton();
            this._btnCancel = new MetroFramework.Controls.MetroButton();
            this._btnApply = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this._btnDefaults = new MetroFramework.Controls.MetroButton();
            this._btnSave = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this._cboLanguage = new MetroFramework.Controls.MetroComboBox();
            this._sbPieOpacity = new MetroFramework.Controls.MetroScrollBar();
            this._chkShowDetailsInFullscreenMode = new MetroFramework.Controls.MetroToggle();
            this._lblShowDetailsInFullscreenMode = new MetroFramework.Controls.MetroLabel();
            this._chkShowPie = new MetroFramework.Controls.MetroToggle();
            this._lblShowPie = new MetroFramework.Controls.MetroLabel();
            this._chkRepeatCards = new MetroFramework.Controls.MetroToggle();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this._chkFullscreenModeEnabled = new MetroFramework.Controls.MetroToggle();
            this._lblFullscreenModeEnabled = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this._btnSelectSearchPath = new MetroFramework.Controls.MetroButton();
            this._lblFavoritedFiles = new MetroFramework.Controls.MetroLabel();
            this._lblExcludedFiles = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this._txtFavoritedFiles = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this._txtExcludedFiles = new MetroFramework.Controls.MetroTextBox();
            this._txtSearchPath = new MetroFramework.Controls.MetroTextBox();
            this._lsvFileTypes = new MetroFramework.Controls.MetroListView();
            this._btnSearch = new MetroFramework.Controls.MetroButton();
            this._pnlMaxHeight = new MetroFramework.Controls.MetroPanel();
            this._pnlMinHeight = new MetroFramework.Controls.MetroPanel();
            this._lblSearched = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this._txtSearch = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._lblFound = new MetroFramework.Controls.MetroLabel();
            this._pnlMaxWidth = new MetroFramework.Controls.MetroPanel();
            this._pnlMinWidth = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this._btnClearLog = new MetroFramework.Controls.MetroButton();
            this._txtLog = new MetroFramework.Controls.MetroTextBox();
            this._pbSearchProgress = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOk
            // 
            this._btnOk.Location = new System.Drawing.Point(5, 3);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 23);
            this._btnOk.TabIndex = 3;
            this._btnOk.Text = "Ok";
            this._btnOk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnOk.UseSelectable = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(198, 3);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnCancel.UseSelectable = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnApply
            // 
            this._btnApply.Location = new System.Drawing.Point(102, 3);
            this._btnApply.Name = "_btnApply";
            this._btnApply.Size = new System.Drawing.Size(75, 23);
            this._btnApply.TabIndex = 3;
            this._btnApply.Text = "Apply";
            this._btnApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnApply.UseSelectable = true;
            this._btnApply.Click += new System.EventHandler(this._btnApply_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroPanel1.Controls.Add(this._btnOk);
            this.metroPanel1.Controls.Add(this._btnCancel);
            this.metroPanel1.Controls.Add(this._btnApply);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(150, 597);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(278, 30);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // _btnDefaults
            // 
            this._btnDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDefaults.BackgroundImage = global::ArtPop.Properties.Resources.appbar_undo;
            this._btnDefaults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnDefaults.Location = new System.Drawing.Point(520, 39);
            this._btnDefaults.Name = "_btnDefaults";
            this._btnDefaults.Size = new System.Drawing.Size(35, 30);
            this._btnDefaults.TabIndex = 14;
            this._btnDefaults.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnDefaults.UseSelectable = true;
            this._btnDefaults.Click += new System.EventHandler(this._btnDefaults_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.BackgroundImage = global::ArtPop.Properties.Resources.appbar_save;
            this._btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnSave.Location = new System.Drawing.Point(479, 39);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(35, 30);
            this._btnSave.TabIndex = 14;
            this._btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnSave.UseSelectable = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 75);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(532, 516);
            this.metroTabControl1.TabIndex = 15;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel15);
            this.metroTabPage1.Controls.Add(this._cboLanguage);
            this.metroTabPage1.Controls.Add(this._sbPieOpacity);
            this.metroTabPage1.Controls.Add(this._chkShowDetailsInFullscreenMode);
            this.metroTabPage1.Controls.Add(this._lblShowDetailsInFullscreenMode);
            this.metroTabPage1.Controls.Add(this._chkShowPie);
            this.metroTabPage1.Controls.Add(this._lblShowPie);
            this.metroTabPage1.Controls.Add(this._chkRepeatCards);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this._chkFullscreenModeEnabled);
            this.metroTabPage1.Controls.Add(this._lblFullscreenModeEnabled);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(524, 474);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "General";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(3, 195);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(66, 19);
            this.metroLabel15.TabIndex = 21;
            this.metroLabel15.Text = "Language";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _cboLanguage
            // 
            this._cboLanguage.FormattingEnabled = true;
            this._cboLanguage.ItemHeight = 23;
            this._cboLanguage.Items.AddRange(new object[] {
            "English",
            "Spanish"});
            this._cboLanguage.Location = new System.Drawing.Point(75, 195);
            this._cboLanguage.Name = "_cboLanguage";
            this._cboLanguage.Size = new System.Drawing.Size(139, 29);
            this._cboLanguage.TabIndex = 20;
            this._cboLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._cboLanguage.UseSelectable = true;
            // 
            // _sbPieOpacity
            // 
            this._sbPieOpacity.LargeChange = 10;
            this._sbPieOpacity.Location = new System.Drawing.Point(129, 155);
            this._sbPieOpacity.Maximum = 100;
            this._sbPieOpacity.Minimum = 10;
            this._sbPieOpacity.MouseWheelBarPartitions = 10;
            this._sbPieOpacity.Name = "_sbPieOpacity";
            this._sbPieOpacity.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this._sbPieOpacity.ScrollbarSize = 10;
            this._sbPieOpacity.Size = new System.Drawing.Size(92, 10);
            this._sbPieOpacity.TabIndex = 19;
            this._sbPieOpacity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._sbPieOpacity.UseBarColor = true;
            this._sbPieOpacity.UseCustomBackColor = true;
            this._sbPieOpacity.UseSelectable = true;
            this._sbPieOpacity.Value = 10;
            // 
            // _chkShowDetailsInFullscreenMode
            // 
            this._chkShowDetailsInFullscreenMode.AutoSize = true;
            this._chkShowDetailsInFullscreenMode.Checked = true;
            this._chkShowDetailsInFullscreenMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowDetailsInFullscreenMode.DisplayStatus = false;
            this._chkShowDetailsInFullscreenMode.Location = new System.Drawing.Point(91, 57);
            this._chkShowDetailsInFullscreenMode.Name = "_chkShowDetailsInFullscreenMode";
            this._chkShowDetailsInFullscreenMode.Size = new System.Drawing.Size(50, 17);
            this._chkShowDetailsInFullscreenMode.TabIndex = 11;
            this._chkShowDetailsInFullscreenMode.Text = "On";
            this._chkShowDetailsInFullscreenMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkShowDetailsInFullscreenMode.UseSelectable = true;
            // 
            // _lblShowDetailsInFullscreenMode
            // 
            this._lblShowDetailsInFullscreenMode.AutoSize = true;
            this._lblShowDetailsInFullscreenMode.Location = new System.Drawing.Point(3, 58);
            this._lblShowDetailsInFullscreenMode.Name = "_lblShowDetailsInFullscreenMode";
            this._lblShowDetailsInFullscreenMode.Size = new System.Drawing.Size(82, 19);
            this._lblShowDetailsInFullscreenMode.TabIndex = 15;
            this._lblShowDetailsInFullscreenMode.Text = "Show Details";
            this._lblShowDetailsInFullscreenMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _chkShowPie
            // 
            this._chkShowPie.AutoSize = true;
            this._chkShowPie.Checked = true;
            this._chkShowPie.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowPie.DisplayStatus = false;
            this._chkShowPie.Location = new System.Drawing.Point(71, 151);
            this._chkShowPie.Name = "_chkShowPie";
            this._chkShowPie.Size = new System.Drawing.Size(50, 17);
            this._chkShowPie.TabIndex = 12;
            this._chkShowPie.Text = "On";
            this._chkShowPie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkShowPie.UseSelectable = true;
            // 
            // _lblShowPie
            // 
            this._lblShowPie.AutoSize = true;
            this._lblShowPie.Location = new System.Drawing.Point(3, 152);
            this._lblShowPie.Name = "_lblShowPie";
            this._lblShowPie.Size = new System.Drawing.Size(62, 19);
            this._lblShowPie.TabIndex = 16;
            this._lblShowPie.Text = "Show Pie";
            this._lblShowPie.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _chkRepeatCards
            // 
            this._chkRepeatCards.AutoSize = true;
            this._chkRepeatCards.DisplayStatus = false;
            this._chkRepeatCards.Location = new System.Drawing.Point(97, 104);
            this._chkRepeatCards.Name = "_chkRepeatCards";
            this._chkRepeatCards.Size = new System.Drawing.Size(50, 17);
            this._chkRepeatCards.TabIndex = 13;
            this._chkRepeatCards.Text = "Off";
            this._chkRepeatCards.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkRepeatCards.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 104);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(88, 19);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Repeat Cards";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _chkFullscreenModeEnabled
            // 
            this._chkFullscreenModeEnabled.AutoSize = true;
            this._chkFullscreenModeEnabled.DisplayStatus = false;
            this._chkFullscreenModeEnabled.Location = new System.Drawing.Point(157, 11);
            this._chkFullscreenModeEnabled.Name = "_chkFullscreenModeEnabled";
            this._chkFullscreenModeEnabled.Size = new System.Drawing.Size(50, 17);
            this._chkFullscreenModeEnabled.TabIndex = 14;
            this._chkFullscreenModeEnabled.Text = "Off";
            this._chkFullscreenModeEnabled.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkFullscreenModeEnabled.UseSelectable = true;
            // 
            // _lblFullscreenModeEnabled
            // 
            this._lblFullscreenModeEnabled.AutoSize = true;
            this._lblFullscreenModeEnabled.Location = new System.Drawing.Point(3, 11);
            this._lblFullscreenModeEnabled.Name = "_lblFullscreenModeEnabled";
            this._lblFullscreenModeEnabled.Size = new System.Drawing.Size(148, 19);
            this._lblFullscreenModeEnabled.TabIndex = 18;
            this._lblFullscreenModeEnabled.Text = "Enable Fullscreen Mode";
            this._lblFullscreenModeEnabled.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this._pbSearchProgress);
            this.metroTabPage2.Controls.Add(this.metroLabel16);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this._btnSelectSearchPath);
            this.metroTabPage2.Controls.Add(this._lblFavoritedFiles);
            this.metroTabPage2.Controls.Add(this._lblExcludedFiles);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this._txtFavoritedFiles);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.Controls.Add(this._txtExcludedFiles);
            this.metroTabPage2.Controls.Add(this._txtSearchPath);
            this.metroTabPage2.Controls.Add(this._lsvFileTypes);
            this.metroTabPage2.Controls.Add(this._btnSearch);
            this.metroTabPage2.Controls.Add(this._pnlMaxHeight);
            this.metroTabPage2.Controls.Add(this._pnlMinHeight);
            this.metroTabPage2.Controls.Add(this._lblSearched);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this._txtSearch);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this._lblFound);
            this.metroTabPage2.Controls.Add(this._pnlMaxWidth);
            this.metroTabPage2.Controls.Add(this._pnlMinWidth);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(524, 474);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Search";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(5, 10);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(226, 19);
            this.metroLabel16.TabIndex = 41;
            this.metroLabel16.Text = "After changing settings, click \"Search\"";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(142, 45);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(34, 19);
            this.metroLabel13.TabIndex = 40;
            this.metroLabel13.Text = "Max";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(65, 45);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Min";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _btnSelectSearchPath
            // 
            this._btnSelectSearchPath.Location = new System.Drawing.Point(3, 157);
            this._btnSelectSearchPath.Name = "_btnSelectSearchPath";
            this._btnSelectSearchPath.Size = new System.Drawing.Size(24, 23);
            this._btnSelectSearchPath.TabIndex = 38;
            this._btnSelectSearchPath.Text = "...";
            this._btnSelectSearchPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnSelectSearchPath.UseSelectable = true;
            this._btnSelectSearchPath.Click += new System.EventHandler(this._btnSelectSearchPath_Click);
            // 
            // _lblFavoritedFiles
            // 
            this._lblFavoritedFiles.AutoSize = true;
            this._lblFavoritedFiles.Location = new System.Drawing.Point(104, 356);
            this._lblFavoritedFiles.Name = "_lblFavoritedFiles";
            this._lblFavoritedFiles.Size = new System.Drawing.Size(16, 19);
            this._lblFavoritedFiles.TabIndex = 37;
            this._lblFavoritedFiles.Tag = "0";
            this._lblFavoritedFiles.Text = "0";
            this._lblFavoritedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblExcludedFiles
            // 
            this._lblExcludedFiles.AutoSize = true;
            this._lblExcludedFiles.Location = new System.Drawing.Point(96, 239);
            this._lblExcludedFiles.Name = "_lblExcludedFiles";
            this._lblExcludedFiles.Size = new System.Drawing.Size(16, 19);
            this._lblExcludedFiles.TabIndex = 36;
            this._lblExcludedFiles.Tag = "0";
            this._lblExcludedFiles.Text = "0";
            this._lblExcludedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(3, 356);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(95, 19);
            this.metroLabel14.TabIndex = 35;
            this.metroLabel14.Text = "Favorited Files:";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _txtFavoritedFiles
            // 
            this._txtFavoritedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtFavoritedFiles.CustomButton.Image = null;
            this._txtFavoritedFiles.CustomButton.Location = new System.Drawing.Point(446, 1);
            this._txtFavoritedFiles.CustomButton.Name = "";
            this._txtFavoritedFiles.CustomButton.Size = new System.Drawing.Size(73, 73);
            this._txtFavoritedFiles.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtFavoritedFiles.CustomButton.TabIndex = 1;
            this._txtFavoritedFiles.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtFavoritedFiles.CustomButton.UseSelectable = true;
            this._txtFavoritedFiles.CustomButton.Visible = false;
            this._txtFavoritedFiles.Lines = new string[0];
            this._txtFavoritedFiles.Location = new System.Drawing.Point(2, 378);
            this._txtFavoritedFiles.MaxLength = 32767;
            this._txtFavoritedFiles.Multiline = true;
            this._txtFavoritedFiles.Name = "_txtFavoritedFiles";
            this._txtFavoritedFiles.PasswordChar = '\0';
            this._txtFavoritedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtFavoritedFiles.SelectedText = "";
            this._txtFavoritedFiles.SelectionLength = 0;
            this._txtFavoritedFiles.SelectionStart = 0;
            this._txtFavoritedFiles.ShortcutsEnabled = true;
            this._txtFavoritedFiles.Size = new System.Drawing.Size(520, 75);
            this._txtFavoritedFiles.TabIndex = 33;
            this._txtFavoritedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtFavoritedFiles.UseSelectable = true;
            this._txtFavoritedFiles.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtFavoritedFiles.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(0, 239);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(93, 19);
            this.metroLabel11.TabIndex = 34;
            this.metroLabel11.Text = "Excluded Files:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _txtExcludedFiles
            // 
            this._txtExcludedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtExcludedFiles.CustomButton.Image = null;
            this._txtExcludedFiles.CustomButton.Location = new System.Drawing.Point(431, 2);
            this._txtExcludedFiles.CustomButton.Name = "";
            this._txtExcludedFiles.CustomButton.Size = new System.Drawing.Size(87, 87);
            this._txtExcludedFiles.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtExcludedFiles.CustomButton.TabIndex = 1;
            this._txtExcludedFiles.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtExcludedFiles.CustomButton.UseSelectable = true;
            this._txtExcludedFiles.CustomButton.Visible = false;
            this._txtExcludedFiles.Lines = new string[0];
            this._txtExcludedFiles.Location = new System.Drawing.Point(1, 261);
            this._txtExcludedFiles.MaxLength = 32767;
            this._txtExcludedFiles.Multiline = true;
            this._txtExcludedFiles.Name = "_txtExcludedFiles";
            this._txtExcludedFiles.PasswordChar = '\0';
            this._txtExcludedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtExcludedFiles.SelectedText = "";
            this._txtExcludedFiles.SelectionLength = 0;
            this._txtExcludedFiles.SelectionStart = 0;
            this._txtExcludedFiles.ShortcutsEnabled = true;
            this._txtExcludedFiles.Size = new System.Drawing.Size(521, 92);
            this._txtExcludedFiles.TabIndex = 32;
            this._txtExcludedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtExcludedFiles.UseSelectable = true;
            this._txtExcludedFiles.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtExcludedFiles.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtSearchPath
            // 
            this._txtSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtSearchPath.CustomButton.Image = null;
            this._txtSearchPath.CustomButton.Location = new System.Drawing.Point(468, 1);
            this._txtSearchPath.CustomButton.Name = "";
            this._txtSearchPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtSearchPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtSearchPath.CustomButton.TabIndex = 1;
            this._txtSearchPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtSearchPath.CustomButton.UseSelectable = true;
            this._txtSearchPath.CustomButton.Visible = false;
            this._txtSearchPath.Lines = new string[0];
            this._txtSearchPath.Location = new System.Drawing.Point(33, 157);
            this._txtSearchPath.MaxLength = 32767;
            this._txtSearchPath.Name = "_txtSearchPath";
            this._txtSearchPath.PasswordChar = '\0';
            this._txtSearchPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtSearchPath.SelectedText = "";
            this._txtSearchPath.SelectionLength = 0;
            this._txtSearchPath.SelectionStart = 0;
            this._txtSearchPath.ShortcutsEnabled = true;
            this._txtSearchPath.Size = new System.Drawing.Size(490, 23);
            this._txtSearchPath.TabIndex = 31;
            this._txtSearchPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtSearchPath.UseSelectable = true;
            this._txtSearchPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtSearchPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtSearchPath.TextChanged += new System.EventHandler(this._txtSearchPath_TextChanged);
            // 
            // _lsvFileTypes
            // 
            this._lsvFileTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsvFileTypes.BackColor = System.Drawing.Color.Black;
            this._lsvFileTypes.CheckBoxes = true;
            this._lsvFileTypes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._lsvFileTypes.ForeColor = System.Drawing.Color.White;
            this._lsvFileTypes.FullRowSelect = true;
            this._lsvFileTypes.GridLines = true;
            listViewItem25.StateImageIndex = 0;
            listViewItem26.StateImageIndex = 0;
            listViewItem27.StateImageIndex = 0;
            listViewItem28.StateImageIndex = 0;
            listViewItem29.StateImageIndex = 0;
            listViewItem30.StateImageIndex = 0;
            this._lsvFileTypes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30});
            this._lsvFileTypes.Location = new System.Drawing.Point(258, 67);
            this._lsvFileTypes.MultiSelect = false;
            this._lsvFileTypes.Name = "_lsvFileTypes";
            this._lsvFileTypes.OwnerDraw = true;
            this._lsvFileTypes.ShowGroups = false;
            this._lsvFileTypes.Size = new System.Drawing.Size(249, 69);
            this._lsvFileTypes.TabIndex = 30;
            this._lsvFileTypes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._lsvFileTypes.UseCompatibleStateImageBehavior = false;
            this._lsvFileTypes.UseSelectable = true;
            this._lsvFileTypes.View = System.Windows.Forms.View.List;
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(3, 195);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(93, 27);
            this._btnSearch.TabIndex = 29;
            this._btnSearch.Text = "Search";
            this._btnSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnSearch.UseSelectable = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _pnlMaxHeight
            // 
            this._pnlMaxHeight.HorizontalScrollbarBarColor = true;
            this._pnlMaxHeight.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlMaxHeight.HorizontalScrollbarSize = 10;
            this._pnlMaxHeight.Location = new System.Drawing.Point(128, 99);
            this._pnlMaxHeight.Name = "_pnlMaxHeight";
            this._pnlMaxHeight.Size = new System.Drawing.Size(63, 20);
            this._pnlMaxHeight.TabIndex = 21;
            this._pnlMaxHeight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._pnlMaxHeight.VerticalScrollbarBarColor = true;
            this._pnlMaxHeight.VerticalScrollbarHighlightOnWheel = false;
            this._pnlMaxHeight.VerticalScrollbarSize = 10;
            // 
            // _pnlMinHeight
            // 
            this._pnlMinHeight.HorizontalScrollbarBarColor = true;
            this._pnlMinHeight.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlMinHeight.HorizontalScrollbarSize = 10;
            this._pnlMinHeight.Location = new System.Drawing.Point(52, 99);
            this._pnlMinHeight.Name = "_pnlMinHeight";
            this._pnlMinHeight.Size = new System.Drawing.Size(61, 20);
            this._pnlMinHeight.TabIndex = 23;
            this._pnlMinHeight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._pnlMinHeight.VerticalScrollbarBarColor = true;
            this._pnlMinHeight.VerticalScrollbarHighlightOnWheel = false;
            this._pnlMinHeight.VerticalScrollbarSize = 10;
            // 
            // _lblSearched
            // 
            this._lblSearched.AutoSize = true;
            this._lblSearched.Location = new System.Drawing.Point(297, 190);
            this._lblSearched.Name = "_lblSearched";
            this._lblSearched.Size = new System.Drawing.Size(74, 19);
            this._lblSearched.TabIndex = 27;
            this._lblSearched.Text = "Search Info";
            this._lblSearched.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Width";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(258, 45);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "File Types";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _txtSearch
            // 
            this._txtSearch.AutoSize = true;
            this._txtSearch.Location = new System.Drawing.Point(1, 136);
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.Size = new System.Drawing.Size(77, 19);
            this._txtSearch.TabIndex = 18;
            this._txtSearch.Text = "Search Path";
            this._txtSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(1, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Height";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblFound
            // 
            this._lblFound.AutoSize = true;
            this._lblFound.Location = new System.Drawing.Point(190, 190);
            this._lblFound.Name = "_lblFound";
            this._lblFound.Size = new System.Drawing.Size(16, 19);
            this._lblFound.TabIndex = 25;
            this._lblFound.Text = "0";
            this._lblFound.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _pnlMaxWidth
            // 
            this._pnlMaxWidth.HorizontalScrollbarBarColor = true;
            this._pnlMaxWidth.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlMaxWidth.HorizontalScrollbarSize = 10;
            this._pnlMaxWidth.Location = new System.Drawing.Point(128, 67);
            this._pnlMaxWidth.Name = "_pnlMaxWidth";
            this._pnlMaxWidth.Size = new System.Drawing.Size(63, 20);
            this._pnlMaxWidth.TabIndex = 22;
            this._pnlMaxWidth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._pnlMaxWidth.VerticalScrollbarBarColor = true;
            this._pnlMaxWidth.VerticalScrollbarHighlightOnWheel = false;
            this._pnlMaxWidth.VerticalScrollbarSize = 10;
            // 
            // _pnlMinWidth
            // 
            this._pnlMinWidth.HorizontalScrollbarBarColor = true;
            this._pnlMinWidth.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlMinWidth.HorizontalScrollbarSize = 10;
            this._pnlMinWidth.Location = new System.Drawing.Point(52, 67);
            this._pnlMinWidth.Name = "_pnlMinWidth";
            this._pnlMinWidth.Size = new System.Drawing.Size(61, 20);
            this._pnlMinWidth.TabIndex = 24;
            this._pnlMinWidth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._pnlMinWidth.VerticalScrollbarBarColor = true;
            this._pnlMinWidth.VerticalScrollbarHighlightOnWheel = false;
            this._pnlMinWidth.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(128, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Filtered:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this._btnClearLog);
            this.metroTabPage3.Controls.Add(this._txtLog);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(524, 474);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Log";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // _btnClearLog
            // 
            this._btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnClearLog.Location = new System.Drawing.Point(3, 293);
            this._btnClearLog.Name = "_btnClearLog";
            this._btnClearLog.Size = new System.Drawing.Size(78, 25);
            this._btnClearLog.TabIndex = 9;
            this._btnClearLog.Text = "Clear";
            this._btnClearLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnClearLog.UseSelectable = true;
            this._btnClearLog.Click += new System.EventHandler(this._btnClearLog_Click);
            // 
            // _txtLog
            // 
            this._txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtLog.CustomButton.Image = null;
            this._txtLog.CustomButton.Location = new System.Drawing.Point(236, 2);
            this._txtLog.CustomButton.Name = "";
            this._txtLog.CustomButton.Size = new System.Drawing.Size(279, 279);
            this._txtLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtLog.CustomButton.TabIndex = 1;
            this._txtLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtLog.CustomButton.UseSelectable = true;
            this._txtLog.CustomButton.Visible = false;
            this._txtLog.Lines = new string[0];
            this._txtLog.Location = new System.Drawing.Point(3, 3);
            this._txtLog.MaxLength = 32767;
            this._txtLog.Multiline = true;
            this._txtLog.Name = "_txtLog";
            this._txtLog.PasswordChar = '\0';
            this._txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtLog.SelectedText = "";
            this._txtLog.SelectionLength = 0;
            this._txtLog.SelectionStart = 0;
            this._txtLog.ShortcutsEnabled = true;
            this._txtLog.Size = new System.Drawing.Size(518, 284);
            this._txtLog.TabIndex = 6;
            this._txtLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtLog.UseSelectable = true;
            this._txtLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _pbSearchProgress
            // 
            this._pbSearchProgress.Location = new System.Drawing.Point(128, 212);
            this._pbSearchProgress.Maximum = 10000;
            this._pbSearchProgress.Name = "_pbSearchProgress";
            this._pbSearchProgress.Size = new System.Drawing.Size(388, 10);
            this._pbSearchProgress.TabIndex = 42;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 650);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this._btnDefaults);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.metroPanel1);
            this.Name = "SettingsForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton _btnOk;
        private MetroFramework.Controls.MetroButton _btnCancel;
        private MetroFramework.Controls.MetroButton _btnApply;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton _btnSave;
        private MetroFramework.Controls.MetroButton _btnDefaults;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroComboBox _cboLanguage;
        private MetroFramework.Controls.MetroScrollBar _sbPieOpacity;
        private MetroFramework.Controls.MetroToggle _chkShowDetailsInFullscreenMode;
        private MetroFramework.Controls.MetroLabel _lblShowDetailsInFullscreenMode;
        private MetroFramework.Controls.MetroToggle _chkShowPie;
        private MetroFramework.Controls.MetroLabel _lblShowPie;
        private MetroFramework.Controls.MetroToggle _chkRepeatCards;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroToggle _chkFullscreenModeEnabled;
        private MetroFramework.Controls.MetroLabel _lblFullscreenModeEnabled;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton _btnSelectSearchPath;
        private MetroFramework.Controls.MetroLabel _lblFavoritedFiles;
        private MetroFramework.Controls.MetroLabel _lblExcludedFiles;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox _txtFavoritedFiles;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox _txtExcludedFiles;
        private MetroFramework.Controls.MetroTextBox _txtSearchPath;
        private MetroFramework.Controls.MetroListView _lsvFileTypes;
        private MetroFramework.Controls.MetroButton _btnSearch;
        private MetroFramework.Controls.MetroPanel _pnlMaxHeight;
        private MetroFramework.Controls.MetroPanel _pnlMinHeight;
        private MetroFramework.Controls.MetroLabel _lblSearched;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel _txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel _lblFound;
        private MetroFramework.Controls.MetroPanel _pnlMaxWidth;
        private MetroFramework.Controls.MetroPanel _pnlMinWidth;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton _btnClearLog;
        private MetroFramework.Controls.MetroTextBox _txtLog;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroProgressBar _pbSearchProgress;
    }
}