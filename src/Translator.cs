using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtPop
{
    public enum LanguageCode
    {
        English = 0,
        Spanish = 1,
    }
    public class Phrase
    {
        public Dictionary<LanguageCode, string> Text = new Dictionary<LanguageCode, string>();
        public int PhraseId { get; } = 0;//English phrase id 
        public Phrase(string english, string spanish = null)
        {
            Text.Add(LanguageCode.English, english);
            Text.Add(LanguageCode.Spanish, (spanish == null) ? english : spanish);
            PhraseId = english.GetHashCode();
            Translator.AddPhrase(this);
        }
        public string Trans(LanguageCode c)
        {
            string trans = "";
            if (Text.TryGetValue(c, out trans) == false)
            {
                throw new Exception("Failure: all Phrases must have some value (or empty string) for each language code ");
            }
            return trans;
        }
    }

    //Applies global/General translation.
    public class Translator
    {
        public static string GetEnglish(string lang)
        {
            if (string.IsNullOrEmpty(lang))
            {
                return "";//null string causes errors
            }
            Phrase p = FindPhrase(lang, Globals.MainForm.OptionsFile.SelectedLanguage);
            if (p != null)
            {
                return p.Trans(LanguageCode.English);
            }
            return lang;
        }
        private static void AddPhraseForLang(LanguageCode code, Phrase p)
        {
            Dictionary<int, Phrase> dict = null;
            if (Phrases.Lexicon.TryGetValue(code, out dict) == false)
            {
                dict = new Dictionary<int, Phrase>();
                Phrases.Lexicon.Add(code, dict);
            }

            string trans = p.Trans(code);
            int hash = trans.GetHashCode();
            if (dict.Keys.Contains(hash))
            {
                //You'll get this if you have untranslated phrases. 
                //Forget empty strings.
                if (trans.Length > 0)
                {
                    Globals.LogError("The phrase " + p + " was already found in the dictionary.");
                }
            }
            else
            {
                dict.Add(hash, p);
            }
        }

        public static void AddPhrase(Phrase p)
        {
            //Don't call this directly, instead create a new phrase manuall.
            foreach (LanguageCode val in Enum.GetValues(typeof(LanguageCode)))
            {
                AddPhraseForLang(val, p);
            }
        }

        public static Phrase FindPhrase(string in_selected_lang, LanguageCode code)
        {
            //For the currently selected language find the translated phrase.
            string err = "No translation for '"
                    + in_selected_lang
                    + "' exists for the currently seelcted lang: '"
                    + code.ToString() + "'.";

            Dictionary<int, Phrase> dict = null;
            if (Phrases.Lexicon.TryGetValue(code, out dict) == false)
            {
                Globals.LogError(err);

                //Return bad phrase.
                return null;
            }

            Phrase trans = null;
            if (dict.TryGetValue(in_selected_lang.GetHashCode(), out trans) == false)
            {
                Globals.LogError(err);
                return null;
            }

            return trans;
        }

        private static bool SwitchingLanguage = false;
        public static void SwitchLanguage(LanguageCode newCode)
        {
            //Copied code from Monogame Toolkit
            if (SwitchingLanguage == false)
            {
                SwitchingLanguage = true;
                TranslateUI(Globals.MainForm, Globals.MainForm.OptionsFile.SelectedLanguage, newCode);

                foreach (MetroForm f in Globals.MainForm.Forms)
                {
                    if (f != null)
                    {
                        if (f.Visible)
                        {
                            TranslateUI(f, Globals.MainForm.OptionsFile.SelectedLanguage, newCode);
                        }
                    }
                }

                Globals.MainForm.OptionsFile.SelectedLanguage = newCode;
                SwitchingLanguage = false;
            }
        }

        public static void TranslateUI(Control cont, LanguageCode from, LanguageCode to)
        {
            //Translates the entire static form.
            try
            {
                TranslateGenericControl(cont, from, to);

                //Translates all elements on the page who have a "text" element
                foreach (Control child in cont.Controls)
                {
                    TranslateUI(child, from, to);
                }

                if (cont as MenuStrip != null)
                {
                    foreach (object child in (cont as MenuStrip).Items)
                    {
                        if (child as ToolStripMenuItem != null)
                        {
                            TranslateUI(child as ToolStripMenuItem, from, to);
                        }
                        else
                        {
                            Globals.LogError("Failed to translate a menu item - no cast availabele for type '"
                                + child.GetType().ToString() + "'");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Globals.LogError(ex.ToString());
            }
        }

        public static void TranslateUI(ToolStripMenuItem cont, LanguageCode from, LanguageCode to)
        {
            //Translates an entire UI of toolstripmenuitem
            try
            {
                TranslateGenericControl(cont, from, to);

                foreach (ToolStripItem child in cont.DropDownItems)
                {
                    //item may be a toolstripseparator
                    if (child as ToolStripMenuItem != null)
                    {
                        TranslateUI(child as ToolStripMenuItem, from, to);
                    }
                }
            }
            catch (Exception ex)
            {
                Globals.LogError(ex.ToString());
            }
        }

        private static void TranslateGenericControl(object cont, LanguageCode from, LanguageCode to)
        {
            //Translates a control if it has a "text" field.
            if (cont == null)
            {
                return;
            }


            //Try to translate combobox items.
            if (cont as ComboBox != null)
            {
                try
                {
                    int selected = -1;
                    if ((cont as ComboBox).SelectedIndex >= 0)
                    {
                        selected = (cont as ComboBox).SelectedIndex;
                    }

                    //Translate the Combo Box Items.
                    List<object> data = new List<object>();
                    foreach (object item in (cont as ComboBox).Items)
                    {
                        if (item as String != null)
                        {
                            data.Add(Translate(item as string, from, to));
                        }
                        else
                        {
                            //Not a string, just add it
                            data.Add(item);
                        }
                    }

                    (cont as ComboBox).Items.Clear();
                    foreach (object item in data)
                    {
                        (cont as ComboBox).Items.Add(item);
                    }

                    (cont as ComboBox).SelectedIndex = selected;
                }
                catch (Exception ex)
                {
                    Globals.LogError("Error translating combobox " + ex.ToString());
                }
            }

            //Generic "Text" Property translation
            if (cont.GetType().GetProperty("Text") != null)
            {
                string txt = cont.GetType().GetProperty("Text").GetValue(cont, null) as string;

                if (!(cont is MetroFramework.Controls.MetroToggle))//MetroToggle has an "on" text but we're not looking for this.
                {
                    if (!string.IsNullOrEmpty(txt))
                    {
                        string trans = Translator.Translate(txt, from, to);

                        cont.GetType().InvokeMember("Text",
                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                            Type.DefaultBinder, cont, new object[] { trans });
                    }
                }
            }

            //A Refresh is required for Metro UI to update the header
            if (cont as MainForm != null)
            {
                (cont as MainForm).Refresh();
            }
        }

        public static string Translate(string in_english)
        {
            return Translate(in_english, LanguageCode.English, Globals.MainForm.OptionsFile.SelectedLanguage);
        }
        public static string Translate(string in_selected_lang, LanguageCode from, LanguageCode to)
        {
            Phrase p = FindPhrase(in_selected_lang, from);
            if (p == null)
            {
                return in_selected_lang;
            }
            return Translate(p, to);
        }

        public static string Translate(Phrase p, LanguageCode? toLang = null)
        {
            if (p == null)
            {
                return "";
            }
            if (toLang == null)
            {
                toLang = Globals.MainForm.OptionsFile.SelectedLanguage;
            }

            if (p.Text == null || p.Text.Count <= (int)toLang)
            {
                Globals.LogError("Phrase " + p.PhraseId + " : '"
                    + ((p.Text != null && p.Text.Count > 0) ? p.Text[0] : "No Text Avail")
                    + "', didn't have a translated item for code : " + toLang.ToString());
            }

            return p.Trans(toLang.Value);
        }

    }


}
