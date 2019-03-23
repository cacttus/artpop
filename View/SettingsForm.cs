using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace ArtPop
{
    public partial class SettingsForm : MetroForm
    {
        public bool ReloadingSettings { get; set; }//True if we need to reload this form to set the defaults.

        private ArtPopNumericUpDown _nudMinWidth;
        private ArtPopNumericUpDown _nudMinHeight;
        private ArtPopNumericUpDown _nudMaxWidth;
        private ArtPopNumericUpDown _nudMaxHeight;
        private bool _bChanged = false;
        private static string SearchMinWidthKey = "search_min_w";
        private static string SearchMinHeightKey = "search_min_h";
        private static string SearchMaxWidthKey = "search_max_w";
        private static string SearchMaxHeightKey = "search_max_h";
        private static string LogDataKey = "log_data";
        private static string SelectedFileTypesKey = "selected_file_types";
        private static string SearchResultsKey = "search_results";
        private static string SearchPathKey = "search_path";
        private static string SessionDataKey = "session_data";
        private static string ExerciseDataKey = "exercise_data";
        private static string GlobalIdGenKey = "global_id_gen";
        private static string ProgramVersionKey = "program_version_key";
        private static string SettingsFileVersionKey = "file_version_key";
        private static string FullscreenModeEnabledKey = "fullscreen_mode_enabled";
        private static string ShowDetailsInFullscreenModeKey = "show_details_in_fullscreen_mode";
        private static string RepeatCardsKey = "repeat_cards_key";
        private static string ExcludedFilesKey = "excluded_files_key";
        private static string FavoritedFilesKey = "FavoritedFilesKey";
        private static string ShowPieKey = "ShowPieKey";
        private static string ShowPieOpacityKey = "ShowPieOpacityKey";

        public List<Session> Sessions { get; set; } = new List<Session>();
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();

        public FileCache FileCache { get; private set; } = new FileCache();

        public bool IsFullscreenEnabled { get {return _chkFullscreenModeEnabled.Checked; } }
        public bool ShowFullscreenDetails  { get { return _chkShowDetailsInFullscreenMode.Checked; }}
        public bool RepeatCards { get { return _chkRepeatCards.Checked; }}
        public bool ShowPie { get { return _chkShowPie.Checked; } }
        public int ShowPieOpacity { get { return (int)((float)_sbPieOpacity.Value * 0.01f * 255); } }//In 32b RGB

        public SettingsForm()
        {
            InitializeComponent();
            

            _nudMinWidth = MakeNud(800, _pnlMinWidth);
            _nudMinHeight = MakeNud(800, _pnlMinHeight);
            _nudMaxWidth = MakeNud(9999, _pnlMaxWidth);
            _nudMaxHeight = MakeNud(9999, _pnlMaxHeight);
            foreach (ListViewItem lsv in _lsvFileTypes.Items)
            {
                lsv.Checked = false;
            }
            SelectFileType("PNG");
            SelectFileType("JPG");
            _txtSearchPath.Text = System.Environment.CurrentDirectory;
            CreateDefaultSession();
            _sbPieOpacity.Value = 60;

        }

        #region Public:Methods

        public void ExcludeFile(string file)
        {
            if (!FileCache.ExcludedFiles.Contains(file))
            {
                FileCache.ExcludedFiles.Add(file);
                //Try to remove it
                FileCache.Files.Remove(file);
                SaveData();
            }
        }
        public void ToggleFavoriteFile(string file)
        {
            file = file.Trim();
            if (!FileCache.FavoritedFiles.Contains(file))
            {
                FileCache.FavoritedFiles.Add(file);
            }
            else
            {
                FileCache.FavoritedFiles.Remove(file);
            }
            SaveData();
        }
        public void RefreshFileCache()
        {
            //Heinous operation.
            //Perform search on the files.
            if (FileCache.Searching)
            {
                FileCache.CancelSearch();
                System.Threading.Thread.Sleep(1500);
                _btnSearch.Text = "Search";
            }
            else
            {
                ImageSizeFilter filter = new ImageSizeFilter();
                filter.MinWidth = (int)_nudMinWidth.Value2;
                filter.MaxWidth = (int)_nudMaxWidth.Value2;
                filter.MinHeight = (int)_nudMinHeight.Value2;
                filter.MaxHeight = (int)_nudMaxHeight.Value2;
                FileCache.Search(_txtSearchPath.Text, filter, () =>
                {
                    UpdateFileCacheInfo();
                    MarkChanged();
                    _btnSearch.Text = "Search";
                });
                _btnSearch.Text = "Cancel Search";
            }
        }
        public void Log(string st)
        {
            string dt = DateTime.Now.ToString("yyyyMMdd,hh:mm:sstt");
            _txtLog.AppendText(dt + "> " + st);
            _txtLog.AppendText(Environment.NewLine);

            //Limit log to not be too much
            int max = 32767 * 2;
            if (_txtLog.Text.Length > max)
            {
                _txtLog.Text = _txtLog.Text.Substring(_txtLog.Text.Length - max);
            }

            _txtLog.SelectionStart = _txtLog.Text.Length;
        }
        public List<string> GetFileTypes()
        {
            List<string> ls = new List<string>();
            foreach (ListViewItem lsv in _lsvFileTypes.Items)
            {
                if (lsv.Checked == true)
                {
                    ls.Add("." + lsv.Text.ToLower());
                }
            }
            return ls;
        }
        #endregion

        #region Private: UI Methods
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //Defaults
            LoadData();
        }
        private void _btnCancel_Click(object sender, EventArgs e)
        {
            if (_bChanged)
            {
                if (MessageBox.Show("Changes have been made, discard?", "Discard?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Hide();
                }
            }
            else
            {
                Hide();
            }
        }
        private void _btnOk_Click(object sender, EventArgs e)
        {
            SaveData();
            Hide();
        }
        private void _btnApply_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void _btnSearch_Click(object sender, EventArgs e)
        {
            RefreshFileCache();

        }
        private void _lsvFileTypes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MarkChanged();
        }
        private void _lsvFileTypes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            MarkChanged();
        }
        private void _txtSearchPath_TextChanged(object sender, EventArgs e)
        {
            MarkChanged();
        }
        private void _btnClearLog_Click(object sender, EventArgs e)
        {
            _txtLog.Text = "";
            MarkChanged(true);
        }
        private void _chkFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            MarkChanged(true);
        }
        private void _btnSave_Click(object sender, EventArgs e)
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] files = Globals.GetValidOpenSaveUserFile(this, true, "Text Files (*.txt)|*.txt|All files (*.*)|*.*", "*.txt", docs);
            if (files.Length == 1)
            {
                StringBuilder data = GetSaveDataString();
                SaveToFile(files[0], data);
            }
        }
        #endregion

        #region Private:Methods

        private void CreateDefaultSession()
        {
            Sessions.Clear();
            Exercises.Clear();

            Session x = new Session();
            x.Name = "Default";
            x.Id = ++Globals.Id_Gen;

            Exercise e1 = new Exercise();
            e1.Name = "5s Speed";
            e1.Instruction = "Draw as much as you can in 5s.";
            e1.Duration = new TimeSpan(0, 0, 5);
            e1.Difficulty = "Medium";
            Exercises.Add(e1);

            Exercise e2 = new Exercise();
            e2.Name = "5Min Speed";
            e2.Instruction = "Draw as much as you can.";
            e2.Duration = new TimeSpan(0, 5, 0);
            e2.Difficulty = "Medium";
            Exercises.Add(e2);

            Exercise e3 = new Exercise();
            e3.Name = "5s Break";
            e3.Instruction = "5s Break";
            e3.Duration = new TimeSpan(0, 0, 5);
            e3.Difficulty = "";
            Exercises.Add(e3);

            x.Exercises.Add(e1.Id);
            x.Exercises.Add(e3.Id);
            //  x.Exercises.Add(e2.Id);

            Sessions.Add(x);
        }
        private void SelectFileType(string st)
        {
            foreach (ListViewItem lsv in _lsvFileTypes.Items)
            {
                if (lsv.Text.ToLower().Trim() == st.ToLower().Trim())
                {
                    lsv.Checked = true;
                    return;
                }
            }
            Globals.LogWarn("Could not find file type " + st + " in settings");
        }
        private void UpdateFileCacheInfo()
        {
            _lblFound.Text = FileCache.Files.Count.ToString();
            _lblSearched.Text = FileCache.Searched.ToString();
            _txtExcludedFiles.Text = String.Join("|", FileCache.ExcludedFiles);
            _lblExcludedFiles.Text = FileCache.ExcludedFiles.Count.ToString();
            _txtFavoritedFiles.Text = String.Join("|", FileCache.FavoritedFiles);
            _lblFavoritedFiles.Text = FileCache.FavoritedFiles.Count.ToString();

        }
        private void MarkChanged(bool changed = true)
        {
            _sbPieOpacity.Enabled = _chkShowPie.Enabled;

            _bChanged = changed;
            _btnApply.Enabled = changed;
        }
        private ArtPopNumericUpDown MakeNud(int def, Control swap)
        {
            ArtPopNumericUpDown nud = new ArtPopNumericUpDown();

            nud.Min = 1;
            nud.Max = 32767;
            nud.Value2 = def;
            nud.DataType = DataType.Int32;
            nud.ValueChanged = ValidateImageNuds;

            Globals.SwapControl(swap, nud);

            return nud;
        }
        private void ValidateImageNuds()
        {
            //if (_nudMaxHeight.Value2 < _nudMinHeight.Value2)
            //{
            //    _nudMaxHeight.Value2 = _nudMinHeight.Value2;
            //}
            //if (_nudMaxWidth.Value2 < _nudMinWidth.Value2)
            //{
            //    _nudMaxWidth.Value2 = _nudMinWidth.Value2;
            //}
            MarkChanged();
        }

        private string GetCleanToken(string st)
        {
            st = st.Trim();

            if (st.Length == 0)
            {
                return st;
            }

            if (st[0] == '"')
            {
                st = st.Substring(1);
            }
            if (st[st.Length - 1] == '"')
            {
                st = st.Substring(0, st.Length - 1);
            }

            st = st.Trim();

            return st;
        }
        private bool KeyComp(string key, string token, ref List<string> encountered)
        {
            bool b = key.ToLower() == token.ToLower();

            //Prevent us from accidently having multiple tokesn
            if (b)
            {
                if (encountered.Contains(token.ToLower()))
                {
                    Globals.LogWarn("Settings file token '" + token.ToLower() + "' defined multiple times.");
                }
                else
                {
                    encountered.Add(token.ToLower());
                }
            }
            return b;
        }
        string[] GetKVP(string line)
        {
            string[] kvp = new string[2] { "", "" };
            int n = line.IndexOf('=');
            if (n >= 0)
            {
                kvp[0] = line.Substring(0, n);
                kvp[1] = line.Substring(n + 1, line.Length - n - 1);

                //Put newlines back in
                kvp[1] = kvp[1].Replace("!@!", "\n");
            }
            return kvp;
        }
        private void LoadData()
        {
            try
            {

                List<string> errors = new List<string>();
                List<string> encountered_tokens = new List<string>();
                string[] text = new string[0];
                string path = ReloadingSettings ? "" : Globals.GetSettingsFilePath();

                if (System.IO.File.Exists(path))
                {
                    Globals.LogInfo("Loading Settings from " + path);
                    text = System.IO.File.ReadAllLines(path);
                }
                else
                {
                    Globals.LogInfo("Loading defaults.");
                }

                foreach (string line in text)
                {
                    string[] kvp = GetKVP(line);

                    if (kvp.Length == 2)
                    {
                        string key = GetCleanToken(kvp[0]);
                        string val = GetCleanToken(kvp[1]);

                        if (KeyComp(key, SearchMinWidthKey, ref encountered_tokens))
                        {
                            _nudMinWidth.Value2 = Globals.ParseInt(val, 800);
                        }
                        else if (KeyComp(key, SearchMinHeightKey, ref encountered_tokens))
                        {
                            _nudMinHeight.Value2 = Globals.ParseInt(val, 600);
                        }
                        else if (KeyComp(key, SearchMaxWidthKey, ref encountered_tokens))
                        {
                            _nudMaxWidth.Value2 = Globals.ParseInt(val, 9999);
                        }
                        else if (KeyComp(key, SearchMaxHeightKey, ref encountered_tokens))
                        {
                            _nudMaxHeight.Value2 = Globals.ParseInt(val, 9999);
                        }
                        else if (KeyComp(key, LogDataKey, ref encountered_tokens))
                        {
                            string logrep = val.Replace("<br/>", Environment.NewLine);
                            _txtLog.Text = logrep;
                        }
                        else if (KeyComp(key, SelectedFileTypesKey, ref encountered_tokens))
                        {
                            string[] vals = val.Split('|');
                            foreach (string v in vals)
                            {
                                string v2 = v.Trim();
                                SelectFileType(v2);
                            }
                        }
                        else if (KeyComp(key, SearchResultsKey, ref encountered_tokens))
                        {
                            string[] vals = val.Split('|');
                            FileCache.Files.Clear();

                            foreach (string v in vals)
                            {
                                string v2 = v.Trim();
                                FileCache.Files.Add(v);
                            }
                            UpdateFileCacheInfo();
                        }
                        else if (KeyComp(key, SearchPathKey, ref encountered_tokens))
                        {
                            _txtSearchPath.Text = val.Trim();
                        }
                        else if (KeyComp(key, SessionDataKey, ref encountered_tokens))
                        {
                            Sessions = JsonConvert.DeserializeObject<List<Session>>(val);
                        }
                        else if (KeyComp(key, ExerciseDataKey, ref encountered_tokens))
                        {
                            Exercises = JsonConvert.DeserializeObject<List<Exercise>>(val);
                        }
                        else if (KeyComp(key, GlobalIdGenKey, ref encountered_tokens))
                        {
                            Globals.Id_Gen = Globals.ParseInt(val, 0);
                        }
                        else if (KeyComp(key, SettingsFileVersionKey, ref encountered_tokens))
                        {
                           //Compare with previous settings file version..
                        }
                        else if (KeyComp(key, ProgramVersionKey, ref encountered_tokens))
                        {
                          //Compare with previous program version..
                        }
                        else if (KeyComp(key, FullscreenModeEnabledKey, ref encountered_tokens))
                        {
                            _chkFullscreenModeEnabled.Checked = Globals.ParseBool(val, false);
                        }
                        else if (KeyComp(key, ShowDetailsInFullscreenModeKey, ref encountered_tokens))
                        {
                            _chkShowDetailsInFullscreenMode.Checked = Globals.ParseBool(val, false);
                        }
                        else if (KeyComp(key, RepeatCardsKey, ref encountered_tokens))
                        {
                            _chkRepeatCards.Checked = Globals.ParseBool(val, false);
                        }
                        else if (KeyComp(key, ExcludedFilesKey, ref encountered_tokens))
                        {
                            string[] vals = val.Split('|');
                            FileCache.ExcludedFiles.Clear();

                            foreach (string v in vals)
                            {
                                string v2 = v.Trim();
                                FileCache.ExcludedFiles.Add(v);
                            }
                            UpdateFileCacheInfo();
                        }
                        else if (KeyComp(key, FavoritedFilesKey, ref encountered_tokens))
                        {
                            string[] vals = val.Split('|');
                            FileCache.FavoritedFiles.Clear();

                            foreach (string v in vals)
                            {
                                string v2 = v.Trim();
                                FileCache.FavoritedFiles.Add(v);
                            }
                            UpdateFileCacheInfo();
                        }
                        else if (KeyComp(key, ShowPieKey, ref encountered_tokens))
                        {
                            _chkShowPie.Checked = Globals.ParseBool(val, false);
                        }
                        else if (KeyComp(key, ShowPieOpacityKey, ref encountered_tokens))
                        {
                            _sbPieOpacity.Value = Globals.ParseInt(val, _sbPieOpacity.Maximum);
                        }

                        else
                        {
                            errors.Add("Unrecognized Settings key '" + key + "'");
                        }

                    }
                }

                //to prevent us from overwriting the errors textobx
                foreach (string e in errors)
                {
                    Globals.LogError(e);
                }

            }
            catch (Exception ex)
            {
                Globals.LogError("Error loading settings:" + ex.ToString());
            }

 

            Globals.MainForm.UpdateData();

            MarkChanged(false);
        }
        private void WriteValue(ref StringBuilder data, string key, string value)
        {
            value = value.Replace("\r", "");// Remove the dumb \r

            value = value.Replace("\n", "!@!");// This prevents newlines from screwing our file up
            data.Append("\"" + key + "\"" + "=" + "\"" + value + "\"" + "\r\n");
        }
        public void SaveData()
        {
            try
            {
                //Set reloadingsettings to false to prevent us from keeping on loading the defaults.
                this.ReloadingSettings = false;

                Globals.LogInfo("Saving Settings. ");

                StringBuilder data = GetSaveDataString();

                string path = Globals.GetSettingsFilePath();

                SaveToFile(path, data);
            }
            catch (Exception ex)
            {
                Globals.LogError("Error writing file: \r\n " + ex.ToString());
            }


            LoadData();
        }
        private void SaveToFile(string path, StringBuilder data)
        {
            Globals.LogInfo("Saving to " + path);

            string dir = System.IO.Path.GetDirectoryName(path);
            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }

            System.IO.File.WriteAllText(path, data.ToString());
        }
        private StringBuilder GetSaveDataString()
        {
            StringBuilder data = new StringBuilder();
            WriteValue(ref data, SearchMinWidthKey, _nudMinWidth.Value2.ToString());
            WriteValue(ref data, SearchMaxWidthKey, _nudMaxWidth.Value2.ToString());
            WriteValue(ref data, SearchMinHeightKey, _nudMinHeight.Value2.ToString());
            WriteValue(ref data, SearchMaxHeightKey, _nudMaxHeight.Value2.ToString());

            string logrep = _txtLog.Text.Replace(Environment.NewLine, "<br/>");
            WriteValue(ref data, LogDataKey, logrep);

            List<string> fts = new List<string>();
            foreach (ListViewItem ls in _lsvFileTypes.Items)
            {
                if (ls.Checked)
                {
                    fts.Add(ls.Text.ToLower());
                }
            }
            WriteValue(ref data, SelectedFileTypesKey, String.Join("|", fts));

            string session_str = JsonConvert.SerializeObject(Sessions);
            WriteValue(ref data, SessionDataKey, session_str);

            string exercise_str = JsonConvert.SerializeObject(Exercises);
            WriteValue(ref data, ExerciseDataKey, exercise_str);

            WriteValue(ref data, SettingsFileVersionKey, Globals.SettingsFileVersion);
            WriteValue(ref data, ProgramVersionKey, Globals.ProgramVersion);
            WriteValue(ref data, GlobalIdGenKey, Globals.Id_Gen.ToString());

            WriteValue(ref data, SearchPathKey, _txtSearchPath.Text);

            string search_results = String.Join("|", FileCache.Files);
            WriteValue(ref data, SearchResultsKey, search_results);
            string excluded_files = String.Join("|", FileCache.ExcludedFiles);
            WriteValue(ref data, ExcludedFilesKey, excluded_files);
            string favorited_files = String.Join("|", FileCache.FavoritedFiles);
            WriteValue(ref data, FavoritedFilesKey, favorited_files);


            WriteValue(ref data, FullscreenModeEnabledKey, _chkFullscreenModeEnabled.Checked ? "True" : "False");
            WriteValue(ref data, ShowDetailsInFullscreenModeKey, _chkShowDetailsInFullscreenMode.Checked ? "True" : "False");
            WriteValue(ref data, RepeatCardsKey, _chkRepeatCards.Checked ? "True" : "False");
            WriteValue(ref data, ShowPieKey, _chkShowPie.Checked ? "True" : "False");
            WriteValue(ref data, ShowPieOpacityKey, _sbPieOpacity.Value.ToString());

            return data;
        }


        #endregion

        public void SetSearchStatus(string stat)
        {
            _lblSearched.Text = stat;
        }
        private void _txtExcludedFiles_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void _btnDefaults_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Revert settings back to defaults?", "Defaults?", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                ReloadingSettings = true;
                Hide();
            }

        }

        private void _btnSelectSearchPath_Click(object sender, EventArgs e)
        {
            string ad = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string[] folder = Globals.GetValidUserFolder(ad, false);
            if(folder.Length==1)
            {
                _txtSearchPath.Text = folder[0];
                MarkChanged();
            }
        }

        private void _txtSearchPath_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
