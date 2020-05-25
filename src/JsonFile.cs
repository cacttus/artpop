using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ArtPop
{
    //Fucky shit right here.
    public class JsonFile<T> : MonoEditFile where T : JsonFile<T>
    {
        public override void SaveAs(string loc)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            {
                LoadedOrSavedFileName = loc;
                string jsonLoc = Path.Combine(Path.GetDirectoryName(loc), Path.GetFileNameWithoutExtension(loc) + ".json");
                try
                {
                    string output = JsonConvert.SerializeObject(this as T);
                    File.WriteAllText(loc, output);
                }
                catch (Exception ex)
                {
                    Globals.LogError("Failed to save Json File: " + ex.ToString());
                }
            }
            sw.Stop();
            Globals.MainForm.SetStatus("Saved '" + loc + "' in " + Globals.TimeSpanToString(sw.Elapsed));
        }

        public override object Load(string loc)
        {
            T ret = null;
            try
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                {
                    string text = System.IO.File.ReadAllText(loc);
                    ret = JsonConvert.DeserializeObject<T>(text);
                    ret.LoadedOrSavedFileName = loc;

                    ret.PostLoad();
                }
                sw.Stop();
                Globals.MainForm.SetStatus("Loaded '" + loc + "' in " + Globals.TimeSpanToString(sw.Elapsed));
            }
            catch (Exception ex)
            {
                Globals.LogError("Failed to save Json File: " + ex.ToString());
            }
            return ret;
        }


    }
}
