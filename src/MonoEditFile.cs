using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ArtPop
{
    public abstract class MonoEditFile
    {
        [JsonIgnore]
        public string LoadedOrSavedFileName { get; set; } = "";

        public MonoEditFile()
        {

        }
        public void Save()
        {
            SaveAs(LoadedOrSavedFileName);
        }

        public virtual void PostLoad()
        {
            //Override to post load stuff
        }

        public abstract void SaveAs(string loc);
        public abstract object Load(string loc);

        public object CreateOrLoad(string loc)
        {
            if (!System.IO.File.Exists(loc))
            {
                SaveAs(loc);
            }

            return Load(loc);
        }
    }
}