using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPop
{
    //Unused generic version of settings.
    public class Settings
    {
        public Func<Settings, string, string, bool> ProcessToken = null;
        public Func<Settings, StringBuilder> GetSaveDataString = null;
        List<string> EncounteredTokens = null;

        public Settings(Func<Settings, string, string, bool> pt, Func<Settings, StringBuilder> gsds)
        {
            ProcessToken = pt;
            GetSaveDataString = gsds;
        }

        public void WriteValue(ref StringBuilder data, string key, string value)
        {
            value = value.Replace("\r", "");// Remove the dumb \r

            value = value.Replace("\n", "!@!");// This prevents newlines from screwing our file up
            data.Append("\"" + key + "\"" + "=" + "\"" + value + "\"" + "\r\n");
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
        public bool KeyComp(string key, string token)
        {
            bool b = key.ToLower() == token.ToLower();

            //Prevent us from accidently having multiple tokesn
            if (b)
            {
                if (EncounteredTokens.Contains(token.ToLower()))
                {
                    Globals.LogWarn("Settings file token '" + token.ToLower() + "' defined multiple times.");
                }
                else
                {
                    EncounteredTokens.Add(token.ToLower());
                }
            }
            return b;
        }
        private string[] GetKVP(string line)
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

        public void SaveData(Action PostLoad)
        {
            try
            {
                Globals.LogInfo("Saving Settings. ");

                StringBuilder data = GetSaveDataString(this);

                string path = Globals.GetSettingsFilePath();

                SaveToFile(path, data);
            }
            catch (Exception ex)
            {
                Globals.LogError("Error writing file: \r\n " + ex.ToString());
            }

            LoadData(PostLoad);
        }
        public void SaveToFile(string path, StringBuilder data)
        {
            Globals.LogInfo("Saving to " + path);

            string dir = System.IO.Path.GetDirectoryName(path);
            if (!System.IO.Directory.Exists(dir))
            {
                System.IO.Directory.CreateDirectory(dir);
            }

            System.IO.File.WriteAllText(path, data.ToString());
        }

        public void LoadData(Action PostLoad )
        {
            try
            {

                List<string> errors = new List<string>();
                EncounteredTokens = new List<string>();
                string[] text = new string[0];
                string path = Globals.GetSettingsFilePath();

                Globals.LogInfo("Loading Settings from " + path);

                if (System.IO.File.Exists(path))
                {
                    text = System.IO.File.ReadAllLines(path);
                }

                foreach (string line in text)
                {
                    string[] kvp = GetKVP(line);

                    if (kvp.Length == 2)
                    {
                        string key = GetCleanToken(kvp[0]);
                        string val = GetCleanToken(kvp[1]);

                       if( ProcessToken(this, key, val) == false)
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

            PostLoad?.Invoke();

        }

    }
}
