using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ArtPop
{
    [Serializable]
    public class Session
    {
        public int Id;
        public string Name;

        public List<int> Exercises = new List<int>();
    }
    [Serializable]
    public class Exercise
    {
        public int Id;
        public string Name;
        public string Instruction;
        public string Difficulty;
        public TimeSpan Duration;

    }

    public enum AddEditMode
    {
        Add,Edit
    }
    public static class Globals
    {
        public static string SettingsFileVersion = "0.0.2";
        public static string ProgramVersion = "0.0.2";
        public static string ProgramName ="ARTPOP";
        public static string ProgramDescriptionShort = "Practice tool";
        public static int Id_Gen = 0;
        public static MainForm MainForm { get; private set; } = null;
        public static void SetMainForm(MainForm mf)
        {
            MainForm = mf;
        }
        public static ExerciseTimer SetExerciseTimer(System.Windows.Forms.Label label)
        {
            //Swaps a winforms label with an exercisetimer class.
            ExerciseTimer et = new ExerciseTimer();
            Globals.SwapControl(label, et);
            et.Font = label.Font;
            et.ForeColor = label.ForeColor;
            return et;
        }
        public static void LogError(string st)
        {
            LogInfo(st, "Error:");
            
        }
        public static void LogWarn(string st)
        {
            LogInfo(st, "Warn:");
        }
        public static void LogInfo(string st, string prefix="")
        {
            if (prefix == "")
            {
                st = "Info:" + st ;
            }
            else
            {
                st = prefix + st ;
            }
            Globals.MainForm.SettingsForm.Log(st);

        }
        public static int ParseInt(string st, int def)
        {
            int n = 0;
            if (Int32.TryParse(st, out n)) {
                return n;
            }
            return def;
        }
        public static bool ParseBool(string st, bool def)
        {
            bool n = false;
            if (Boolean.TryParse(st, out n))
            {
                return n;
            }
            return def;
        }
        public static string GetSettingsFilePath()
        {
            string ad = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string path = System.IO.Path.Combine(ad, "ArtPop");
            path = System.IO.Path.Combine(path, "Settings.txt");

            return path;
        }
        public static void SwapControl(Control toRemove, Control toAdd)
        {
            toAdd.Top = toRemove.Top;
            toAdd.Left = toRemove.Left;
            toAdd.Width = toRemove.Width;
            toAdd.Height = toRemove.Height;
            toAdd.Dock = toRemove.Dock;
            toAdd.Anchor = toRemove.Anchor;


            Control parent = toRemove.Parent;
            if (parent != null)
            {
                parent.Controls.Remove(toRemove);
                parent.Controls.Add(toAdd);
            }

        }

        public static string[] GetValidOpenSaveUserFile(IWin32Window owner, bool bSave,
    string filter, string defaultext, string initialdir, bool multiple = false, string defaultName = "")
        {
            return GetValidOpenSaveUserFile(owner, bSave,
             filter, filter, defaultext, initialdir, multiple, defaultName);
        }
        public static string[] GetValidOpenSaveUserFile(IWin32Window owner, bool bSave, string saveFilter,
            string loadFilter, string defaultext, string initialdir, bool multiple = false, string defaultName = "")
        {
            int num = 0;
            FileDialog fileDialog;
            string str;
            if (!bSave)
            {
                fileDialog = (FileDialog)new OpenFileDialog();
                str = loadFilter;
                (fileDialog as OpenFileDialog).Multiselect = multiple;
            }
            else
            {
                fileDialog = (FileDialog)new SaveFileDialog();
                str = saveFilter;
            }
            string fullPath = Path.GetFullPath(initialdir);
            fileDialog.InitialDirectory = fullPath;
            fileDialog.DefaultExt = defaultext;
            fileDialog.Filter = str;
            fileDialog.FilterIndex = num;
            if (string.IsNullOrEmpty(defaultName) == false)
            {
                fileDialog.FileName = defaultName + defaultext;
            }
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return new string[0];
            }
            if (!bSave && !File.Exists(fileDialog.FileName))
            {
                return new string[0];
            }
            return fileDialog.FileNames;
        }

    }
}
