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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("PNG");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("JPG");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("TGA");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("BMP");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("TIFF");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("GIF");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this._pnlMinWidth = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._pnlMinHeight = new MetroFramework.Controls.MetroPanel();
            this._btnOk = new MetroFramework.Controls.MetroButton();
            this._btnCancel = new MetroFramework.Controls.MetroButton();
            this._btnApply = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lblExcludedFiles = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this._txtExcludedFiles = new MetroFramework.Controls.MetroTextBox();
            this._txtSearchPath = new MetroFramework.Controls.MetroTextBox();
            this._lsvFileTypes = new MetroFramework.Controls.MetroListView();
            this._btnSearch = new MetroFramework.Controls.MetroButton();
            this._pnlMaxHeight = new MetroFramework.Controls.MetroPanel();
            this._lblSearched = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this._lblFound = new MetroFramework.Controls.MetroLabel();
            this._pnlMaxWidth = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this._txtLog = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this._btnClearLog = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._chkShowDetailsInFullscreenMode = new MetroFramework.Controls.MetroToggle();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this._chkRepeatCards = new MetroFramework.Controls.MetroToggle();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this._chkFullscreenModeEnabled = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this._chkShowPie = new MetroFramework.Controls.MetroToggle();
            this._sbPieOpacity = new MetroFramework.Controls.MetroScrollBar();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this._txtFavoritedFiles = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this._lblFavoritedFiles = new MetroFramework.Controls.MetroLabel();
            this._btnSave = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Width";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _pnlMinWidth
            // 
            this._pnlMinWidth.HorizontalScrollbarBarColor = true;
            this._pnlMinWidth.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlMinWidth.HorizontalScrollbarSize = 10;
            this._pnlMinWidth.Location = new System.Drawing.Point(64, 27);
            this._pnlMinWidth.Name = "_pnlMinWidth";
            this._pnlMinWidth.Size = new System.Drawing.Size(61, 20);
            this._pnlMinWidth.TabIndex = 2;
            this._pnlMinWidth.VerticalScrollbarBarColor = true;
            this._pnlMinWidth.VerticalScrollbarHighlightOnWheel = false;
            this._pnlMinWidth.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Height";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _pnlMinHeight
            // 
            this._pnlMinHeight.HorizontalScrollbarBarColor = true;
            this._pnlMinHeight.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlMinHeight.HorizontalScrollbarSize = 10;
            this._pnlMinHeight.Location = new System.Drawing.Point(64, 50);
            this._pnlMinHeight.Name = "_pnlMinHeight";
            this._pnlMinHeight.Size = new System.Drawing.Size(61, 20);
            this._pnlMinHeight.TabIndex = 2;
            this._pnlMinHeight.VerticalScrollbarBarColor = true;
            this._pnlMinHeight.VerticalScrollbarHighlightOnWheel = false;
            this._pnlMinHeight.VerticalScrollbarSize = 10;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._lblFavoritedFiles);
            this.groupBox1.Controls.Add(this._lblExcludedFiles);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this._txtFavoritedFiles);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this._txtExcludedFiles);
            this.groupBox1.Controls.Add(this._txtSearchPath);
            this.groupBox1.Controls.Add(this._lsvFileTypes);
            this.groupBox1.Controls.Add(this._btnSearch);
            this.groupBox1.Controls.Add(this._pnlMaxHeight);
            this.groupBox1.Controls.Add(this._pnlMinHeight);
            this.groupBox1.Controls.Add(this._lblSearched);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this._lblFound);
            this.groupBox1.Controls.Add(this._pnlMaxWidth);
            this.groupBox1.Controls.Add(this._pnlMinWidth);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(23, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // _lblExcludedFiles
            // 
            this._lblExcludedFiles.AutoSize = true;
            this._lblExcludedFiles.Location = new System.Drawing.Point(109, 202);
            this._lblExcludedFiles.Name = "_lblExcludedFiles";
            this._lblExcludedFiles.Size = new System.Drawing.Size(16, 19);
            this._lblExcludedFiles.TabIndex = 15;
            this._lblExcludedFiles.Tag = "0";
            this._lblExcludedFiles.Text = "0";
            this._lblExcludedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(13, 202);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(93, 19);
            this.metroLabel11.TabIndex = 15;
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
            this._txtExcludedFiles.CustomButton.Location = new System.Drawing.Point(362, 1);
            this._txtExcludedFiles.CustomButton.Name = "";
            this._txtExcludedFiles.CustomButton.Size = new System.Drawing.Size(41, 41);
            this._txtExcludedFiles.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtExcludedFiles.CustomButton.TabIndex = 1;
            this._txtExcludedFiles.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtExcludedFiles.CustomButton.UseSelectable = true;
            this._txtExcludedFiles.CustomButton.Visible = false;
            this._txtExcludedFiles.Lines = new string[0];
            this._txtExcludedFiles.Location = new System.Drawing.Point(14, 224);
            this._txtExcludedFiles.MaxLength = 32767;
            this._txtExcludedFiles.Multiline = true;
            this._txtExcludedFiles.Name = "_txtExcludedFiles";
            this._txtExcludedFiles.PasswordChar = '\0';
            this._txtExcludedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtExcludedFiles.SelectedText = "";
            this._txtExcludedFiles.SelectionLength = 0;
            this._txtExcludedFiles.SelectionStart = 0;
            this._txtExcludedFiles.ShortcutsEnabled = true;
            this._txtExcludedFiles.Size = new System.Drawing.Size(404, 43);
            this._txtExcludedFiles.TabIndex = 14;
            this._txtExcludedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtExcludedFiles.UseSelectable = true;
            this._txtExcludedFiles.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtExcludedFiles.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtExcludedFiles.Click += new System.EventHandler(this._txtExcludedFiles_Click);
            // 
            // _txtSearchPath
            // 
            this._txtSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtSearchPath.CustomButton.Image = null;
            this._txtSearchPath.CustomButton.Location = new System.Drawing.Point(366, 1);
            this._txtSearchPath.CustomButton.Name = "";
            this._txtSearchPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtSearchPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtSearchPath.CustomButton.TabIndex = 1;
            this._txtSearchPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtSearchPath.CustomButton.UseSelectable = true;
            this._txtSearchPath.CustomButton.Visible = false;
            this._txtSearchPath.Lines = new string[0];
            this._txtSearchPath.Location = new System.Drawing.Point(14, 115);
            this._txtSearchPath.MaxLength = 32767;
            this._txtSearchPath.Name = "_txtSearchPath";
            this._txtSearchPath.PasswordChar = '\0';
            this._txtSearchPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtSearchPath.SelectedText = "";
            this._txtSearchPath.SelectionLength = 0;
            this._txtSearchPath.SelectionStart = 0;
            this._txtSearchPath.ShortcutsEnabled = true;
            this._txtSearchPath.Size = new System.Drawing.Size(388, 23);
            this._txtSearchPath.TabIndex = 12;
            this._txtSearchPath.UseSelectable = true;
            this._txtSearchPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtSearchPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _lsvFileTypes
            // 
            this._lsvFileTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lsvFileTypes.CheckBoxes = true;
            this._lsvFileTypes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._lsvFileTypes.FullRowSelect = true;
            this._lsvFileTypes.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this._lsvFileTypes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this._lsvFileTypes.Location = new System.Drawing.Point(286, 40);
            this._lsvFileTypes.MultiSelect = false;
            this._lsvFileTypes.Name = "_lsvFileTypes";
            this._lsvFileTypes.OwnerDraw = true;
            this._lsvFileTypes.ShowGroups = false;
            this._lsvFileTypes.Size = new System.Drawing.Size(116, 69);
            this._lsvFileTypes.TabIndex = 11;
            this._lsvFileTypes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._lsvFileTypes.UseCompatibleStateImageBehavior = false;
            this._lsvFileTypes.UseSelectable = true;
            this._lsvFileTypes.View = System.Windows.Forms.View.List;
            this._lsvFileTypes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this._lsvFileTypes_ItemCheck);
            this._lsvFileTypes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this._lsvFileTypes_ItemChecked);
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(14, 147);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(93, 27);
            this._btnSearch.TabIndex = 10;
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
            this._pnlMaxHeight.Location = new System.Drawing.Point(136, 50);
            this._pnlMaxHeight.Name = "_pnlMaxHeight";
            this._pnlMaxHeight.Size = new System.Drawing.Size(63, 20);
            this._pnlMaxHeight.TabIndex = 2;
            this._pnlMaxHeight.VerticalScrollbarBarColor = true;
            this._pnlMaxHeight.VerticalScrollbarHighlightOnWheel = false;
            this._pnlMaxHeight.VerticalScrollbarSize = 10;
            // 
            // _lblSearched
            // 
            this._lblSearched.AutoSize = true;
            this._lblSearched.Location = new System.Drawing.Point(187, 166);
            this._lblSearched.Name = "_lblSearched";
            this._lblSearched.Size = new System.Drawing.Size(16, 19);
            this._lblSearched.TabIndex = 8;
            this._lblSearched.Text = "0";
            this._lblSearched.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.metroLabel6.Location = new System.Drawing.Point(127, 166);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Searched:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(295, 18);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "File Types";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(13, 93);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(80, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Search Path:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblFound
            // 
            this._lblFound.AutoSize = true;
            this._lblFound.Location = new System.Drawing.Point(173, 147);
            this._lblFound.Name = "_lblFound";
            this._lblFound.Size = new System.Drawing.Size(16, 19);
            this._lblFound.TabIndex = 7;
            this._lblFound.Text = "0";
            this._lblFound.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _pnlMaxWidth
            // 
            this._pnlMaxWidth.HorizontalScrollbarBarColor = true;
            this._pnlMaxWidth.HorizontalScrollbarHighlightOnWheel = false;
            this._pnlMaxWidth.HorizontalScrollbarSize = 10;
            this._pnlMaxWidth.Location = new System.Drawing.Point(136, 27);
            this._pnlMaxWidth.Name = "_pnlMaxWidth";
            this._pnlMaxWidth.Size = new System.Drawing.Size(63, 20);
            this._pnlMaxWidth.TabIndex = 2;
            this._pnlMaxWidth.VerticalScrollbarBarColor = true;
            this._pnlMaxWidth.VerticalScrollbarHighlightOnWheel = false;
            this._pnlMaxWidth.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(127, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Found:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this._txtLog.CustomButton.Location = new System.Drawing.Point(375, 1);
            this._txtLog.CustomButton.Name = "";
            this._txtLog.CustomButton.Size = new System.Drawing.Size(53, 53);
            this._txtLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtLog.CustomButton.TabIndex = 1;
            this._txtLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtLog.CustomButton.UseSelectable = true;
            this._txtLog.CustomButton.Visible = false;
            this._txtLog.Lines = new string[0];
            this._txtLog.Location = new System.Drawing.Point(23, 576);
            this._txtLog.MaxLength = 32767;
            this._txtLog.Multiline = true;
            this._txtLog.Name = "_txtLog";
            this._txtLog.PasswordChar = '\0';
            this._txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtLog.SelectedText = "";
            this._txtLog.SelectionLength = 0;
            this._txtLog.SelectionStart = 0;
            this._txtLog.ShortcutsEnabled = true;
            this._txtLog.Size = new System.Drawing.Size(429, 55);
            this._txtLog.TabIndex = 5;
            this._txtLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtLog.UseSelectable = true;
            this._txtLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 554);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Log";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.metroPanel1.Location = new System.Drawing.Point(99, 674);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(278, 30);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // _btnClearLog
            // 
            this._btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClearLog.Location = new System.Drawing.Point(377, 637);
            this._btnClearLog.Name = "_btnClearLog";
            this._btnClearLog.Size = new System.Drawing.Size(75, 16);
            this._btnClearLog.TabIndex = 8;
            this._btnClearLog.Text = "Clear";
            this._btnClearLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnClearLog.UseSelectable = true;
            this._btnClearLog.Click += new System.EventHandler(this._btnClearLog_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._sbPieOpacity);
            this.groupBox2.Controls.Add(this._chkShowDetailsInFullscreenMode);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this._chkShowPie);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this._chkRepeatCards);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this._chkFullscreenModeEnabled);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 140);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // _chkShowDetailsInFullscreenMode
            // 
            this._chkShowDetailsInFullscreenMode.AutoSize = true;
            this._chkShowDetailsInFullscreenMode.Checked = true;
            this._chkShowDetailsInFullscreenMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowDetailsInFullscreenMode.DisplayStatus = false;
            this._chkShowDetailsInFullscreenMode.Location = new System.Drawing.Point(266, 47);
            this._chkShowDetailsInFullscreenMode.Name = "_chkShowDetailsInFullscreenMode";
            this._chkShowDetailsInFullscreenMode.Size = new System.Drawing.Size(50, 20);
            this._chkShowDetailsInFullscreenMode.TabIndex = 0;
            this._chkShowDetailsInFullscreenMode.Text = "On";
            this._chkShowDetailsInFullscreenMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkShowDetailsInFullscreenMode.UseSelectable = true;
            this._chkShowDetailsInFullscreenMode.CheckedChanged += new System.EventHandler(this._chkFullscreen_CheckedChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(32, 47);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(228, 19);
            this.metroLabel9.TabIndex = 7;
            this.metroLabel9.Text = "Show Details Pane In Fullscreen Mode";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _chkRepeatCards
            // 
            this._chkRepeatCards.AutoSize = true;
            this._chkRepeatCards.DisplayStatus = false;
            this._chkRepeatCards.Location = new System.Drawing.Point(98, 69);
            this._chkRepeatCards.Name = "_chkRepeatCards";
            this._chkRepeatCards.Size = new System.Drawing.Size(50, 20);
            this._chkRepeatCards.TabIndex = 0;
            this._chkRepeatCards.Text = "Off";
            this._chkRepeatCards.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkRepeatCards.UseSelectable = true;
            this._chkRepeatCards.CheckedChanged += new System.EventHandler(this._chkFullscreen_CheckedChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 68);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(88, 19);
            this.metroLabel10.TabIndex = 7;
            this.metroLabel10.Text = "Repeat Cards";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _chkFullscreenModeEnabled
            // 
            this._chkFullscreenModeEnabled.AutoSize = true;
            this._chkFullscreenModeEnabled.DisplayStatus = false;
            this._chkFullscreenModeEnabled.Location = new System.Drawing.Point(153, 22);
            this._chkFullscreenModeEnabled.Name = "_chkFullscreenModeEnabled";
            this._chkFullscreenModeEnabled.Size = new System.Drawing.Size(50, 20);
            this._chkFullscreenModeEnabled.TabIndex = 0;
            this._chkFullscreenModeEnabled.Text = "Off";
            this._chkFullscreenModeEnabled.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkFullscreenModeEnabled.UseSelectable = true;
            this._chkFullscreenModeEnabled.CheckedChanged += new System.EventHandler(this._chkFullscreen_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 21);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(148, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Enable Fullscreen Mode";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(6, 94);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(62, 19);
            this.metroLabel12.TabIndex = 7;
            this.metroLabel12.Text = "Show Pie";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _chkShowPie
            // 
            this._chkShowPie.AutoSize = true;
            this._chkShowPie.Checked = true;
            this._chkShowPie.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowPie.DisplayStatus = false;
            this._chkShowPie.Location = new System.Drawing.Point(98, 94);
            this._chkShowPie.Name = "_chkShowPie";
            this._chkShowPie.Size = new System.Drawing.Size(50, 20);
            this._chkShowPie.TabIndex = 0;
            this._chkShowPie.Text = "On";
            this._chkShowPie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkShowPie.UseSelectable = true;
            this._chkShowPie.CheckedChanged += new System.EventHandler(this._chkFullscreen_CheckedChanged);
            // 
            // _sbPieOpacity
            // 
            this._sbPieOpacity.LargeChange = 10;
            this._sbPieOpacity.Location = new System.Drawing.Point(266, 103);
            this._sbPieOpacity.Maximum = 100;
            this._sbPieOpacity.Minimum = 10;
            this._sbPieOpacity.MouseWheelBarPartitions = 10;
            this._sbPieOpacity.Name = "_sbPieOpacity";
            this._sbPieOpacity.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this._sbPieOpacity.ScrollbarSize = 10;
            this._sbPieOpacity.Size = new System.Drawing.Size(92, 10);
            this._sbPieOpacity.TabIndex = 8;
            this._sbPieOpacity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._sbPieOpacity.UseBarColor = true;
            this._sbPieOpacity.UseCustomBackColor = true;
            this._sbPieOpacity.UseSelectable = true;
            this._sbPieOpacity.Value = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(173, 95);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(76, 19);
            this.metroLabel13.TabIndex = 7;
            this.metroLabel13.Text = "Pie Opacity";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _txtFavoritedFiles
            // 
            this._txtFavoritedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtFavoritedFiles.CustomButton.Image = null;
            this._txtFavoritedFiles.CustomButton.Location = new System.Drawing.Point(362, 1);
            this._txtFavoritedFiles.CustomButton.Name = "";
            this._txtFavoritedFiles.CustomButton.Size = new System.Drawing.Size(41, 41);
            this._txtFavoritedFiles.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtFavoritedFiles.CustomButton.TabIndex = 1;
            this._txtFavoritedFiles.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtFavoritedFiles.CustomButton.UseSelectable = true;
            this._txtFavoritedFiles.CustomButton.Visible = false;
            this._txtFavoritedFiles.Lines = new string[0];
            this._txtFavoritedFiles.Location = new System.Drawing.Point(15, 292);
            this._txtFavoritedFiles.MaxLength = 32767;
            this._txtFavoritedFiles.Multiline = true;
            this._txtFavoritedFiles.Name = "_txtFavoritedFiles";
            this._txtFavoritedFiles.PasswordChar = '\0';
            this._txtFavoritedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtFavoritedFiles.SelectedText = "";
            this._txtFavoritedFiles.SelectionLength = 0;
            this._txtFavoritedFiles.SelectionStart = 0;
            this._txtFavoritedFiles.ShortcutsEnabled = true;
            this._txtFavoritedFiles.Size = new System.Drawing.Size(404, 43);
            this._txtFavoritedFiles.TabIndex = 14;
            this._txtFavoritedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtFavoritedFiles.UseSelectable = true;
            this._txtFavoritedFiles.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtFavoritedFiles.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(14, 270);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(95, 19);
            this.metroLabel14.TabIndex = 15;
            this.metroLabel14.Text = "Favorited Files:";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblFavoritedFiles
            // 
            this._lblFavoritedFiles.AutoSize = true;
            this._lblFavoritedFiles.Location = new System.Drawing.Point(110, 270);
            this._lblFavoritedFiles.Name = "_lblFavoritedFiles";
            this._lblFavoritedFiles.Size = new System.Drawing.Size(16, 19);
            this._lblFavoritedFiles.TabIndex = 15;
            this._lblFavoritedFiles.Tag = "0";
            this._lblFavoritedFiles.Text = "0";
            this._lblFavoritedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.BackgroundImage = global::ArtPop.Properties.Resources.appbar_save;
            this._btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnSave.Location = new System.Drawing.Point(417, 37);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(35, 30);
            this._btnSave.TabIndex = 14;
            this._btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnSave.UseSelectable = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 727);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._btnClearLog);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this._txtLog);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel _pnlMinWidth;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel _pnlMinHeight;
        private MetroFramework.Controls.MetroButton _btnOk;
        private MetroFramework.Controls.MetroButton _btnCancel;
        private MetroFramework.Controls.MetroButton _btnApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox _txtLog;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel _lblFound;
        private MetroFramework.Controls.MetroLabel _lblSearched;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton _btnSearch;
        private MetroFramework.Controls.MetroListView _lsvFileTypes;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox _txtSearchPath;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel _pnlMaxWidth;
        private MetroFramework.Controls.MetroPanel _pnlMaxHeight;
        private MetroFramework.Controls.MetroButton _btnClearLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroToggle _chkFullscreenModeEnabled;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle _chkShowDetailsInFullscreenMode;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle _chkRepeatCards;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel _lblExcludedFiles;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox _txtExcludedFiles;
        private MetroFramework.Controls.MetroButton _btnSave;
        private MetroFramework.Controls.MetroScrollBar _sbPieOpacity;
        private MetroFramework.Controls.MetroToggle _chkShowPie;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel _lblFavoritedFiles;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox _txtFavoritedFiles;
    }
}