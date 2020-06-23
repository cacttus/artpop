using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace ArtPop
{
   [Serializable]
   public class Session
   {
      public int Id;
      public string Name;

      public List<int> Exercises = new List<int>();
      public Session()
      {
         Id = ++Globals.Id_Gen;
      }
   }
   [Serializable]
   public class Exercise
   {
      public int Id;
      public string Name;
      public string Instruction;
      public string Difficulty;
      public TimeSpan Duration;
      public bool TakeABreak; // if this exercise is to pause the editor.
      public int RepeatCount;
      public Exercise()
      {
         Id = ++Globals.Id_Gen;
      }
   }

   public enum AddEditMode
   {
      Add, Edit
   }
   public static class Globals
   {
      public static void ToggleBackground(MetroButton objButton, bool bEnable)
      {
         float value = 1.0f;
         if (!bEnable)
         {
            value = 0.2f;
         }
         Bitmap saved = new Bitmap(objButton.BackgroundImage);
         objButton.BackgroundImage = new ImageMaker(saved).BlackAndWhite().SetAlpha(value).Bitmap;
      }

      public static string SettingsFileVersion = "0.0.3";
      public static string ProgramVersion = "0.0.3";
      public static string ProgramName = "ARTPOP";
      public static string ProgramDescriptionShort = "Practice tool";
      public static int Id_Gen = 0;
      public static MainForm MainForm { get; private set; } = null;
      public static void SetMainForm(MainForm mf)
      {
         MainForm = mf;
      }
      public static void SetExerciseTimer(System.Windows.Forms.Label label)
      {
         //Swaps a winforms label with an exercisetimer class.
         ExerciseTimer et = new ExerciseTimer();
         Globals.SwapControl(label, et);
         et.Font = label.Font;
         et.ForeColor = label.ForeColor;
      }
      public static void LogError(string st)
      {
         LogInfo(st, "Error: ");
      }
      public static void LogWarn(string st)
      {
         LogInfo(st, "Warning: ");
      }
      public static void LogInfo(string st, string prefix = "")
      {
         if (prefix != "")
         {
            st = prefix + st;
         }
         if (Globals.MainForm != null)
         {
            Globals.MainForm.Log(st);
         }
      }
      public static int ParseInt(string st, int def)
      {
         int n = 0;
         if (Int32.TryParse(st, out n))
         {
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
      public static string[] GetValidUserFolder(string initialdir, bool multiple)
      {
         using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
         {
            folderBrowserDialog.Description = "Select a folder";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
               return new string[1]
               {
                        folderBrowserDialog.SelectedPath
               };
         }
         return new string[0];
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
      private class Injection : System.Windows.Forms.Button
      {
         public void injectionMethod()
         {
            Enabled = false;
         }
      }
      private const int bytesPerPixel = 4;

      /// <summary>
      /// Change the opacity of an image
      /// </summary>
      /// <param name="originalImage">The original image</param>
      /// <param name="opacity">Opacity, where 1.0 is no opacity, 0.0 is full transparency</param>
      /// <returns>The changed image</returns>
      public static Image ChangeImageOpacity(Image originalImage, double opacity)
      {
         if ((originalImage.PixelFormat & PixelFormat.Indexed) == PixelFormat.Indexed)
         {
            // Cannot modify an image with indexed colors
            return originalImage;
         }

         Bitmap bmp = (Bitmap)originalImage.Clone();

         // Specify a pixel format.
         PixelFormat pxf = PixelFormat.Format32bppArgb;

         // Lock the bitmap's bits.
         Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
         BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);

         // Get the address of the first line.
         IntPtr ptr = bmpData.Scan0;

         // Declare an array to hold the bytes of the bitmap.
         // This code is specific to a bitmap with 32 bits per pixels 
         // (32 bits = 4 bytes, 3 for RGB and 1 byte for alpha).
         int numBytes = bmp.Width * bmp.Height * bytesPerPixel;
         byte[] argbValues = new byte[numBytes];

         // Copy the ARGB values into the array.
         System.Runtime.InteropServices.Marshal.Copy(ptr, argbValues, 0, numBytes);

         // Manipulate the bitmap, such as changing the
         // RGB values for all pixels in the the bitmap.
         for (int counter = 0; counter < argbValues.Length; counter += bytesPerPixel)
         {
            // argbValues is in format BGRA (Blue, Green, Red, Alpha)

            // If 100% transparent, skip pixel
            if (argbValues[counter + bytesPerPixel - 1] == 0)
               continue;

            int pos = 0;
            pos++; // B value
            pos++; // G value
            pos++; // R value

            argbValues[counter + pos] = (byte)(255 * opacity);
         }

         // Copy the ARGB values back to the bitmap
         System.Runtime.InteropServices.Marshal.Copy(argbValues, 0, ptr, numBytes);

         // Unlock the bits.
         bmp.UnlockBits(bmpData);

         return bmp;
      }
      public static void RegisterExtensions(Control c)
      {
         if (c is MetroFramework.Controls.MetroButton)
         {
            c.EnabledChanged += (s, e) =>
            {
               if (c.Enabled)
               {
                  c.BackgroundImage = ChangeImageOpacity(c.BackgroundImage, 1.0f);
               }
               else
               {
                  c.BackgroundImage = ChangeImageOpacity(c.BackgroundImage, 0.3f);
               }
            };
         }
         foreach (Control cc in c.Controls)
         {
            RegisterExtensions(cc);
         }
      }
      public static T GetEnumFromComboBox<T>(MetroComboBox b) where T : struct, IConvertible
      {
         //Gets the enum for combo box - with translation support
         //https://stackoverflow.com/questions/79126/create-generic-method-constraining-t-to-an-enum/
         string lang = b.SelectedItem as string;
         //Set default enum value to first value
         T code = (T)Enum.ToObject(typeof(T), 0);

         string eng = Translator.GetEnglish(lang);

         Enum.TryParse(eng, out code);
         return code;
      }
      public static void SelectCboItem(System.Windows.Forms.ComboBox cb, string selected, int defIndex)
      {
         //Translate s
         string selected_trans = Translator.Translate(selected);
         for (int i = 0; i < cb.Items.Count; ++i)
         {
            //Do some translation voodoo
            string item = (cb.Items[i] as string);
            Phrase p = Translator.FindPhrase(item, Globals.MainForm.OptionsFile.SelectedLanguage);
            string item_trans = Translator.Translate(p, Globals.MainForm.OptionsFile.SelectedLanguage);

            if (item_trans.Equals(selected_trans))
            {
               cb.SelectedIndex = i;
               return;
            }
         }
         if (cb.Items.Count > 0)
         {
            Globals.LogError("Could not find combobox item: " + selected);
            if (defIndex < cb.Items.Count)
            {
               cb.SelectedIndex = defIndex;
            }
         }
      }
      public static Icon LoadIconResource(string name, string sub = "", string subdir = "")
      {
         Icon ico = null;
         try
         {
            string dir = Assembly.GetEntryAssembly().Location;
            dir = Path.GetDirectoryName(dir);
            if (string.IsNullOrEmpty(subdir) == false)
            {
               dir = Path.Combine(dir, sub, subdir, name);
            }
            else
            {
               dir = Path.Combine(dir, sub, name);
            }
            ico = new Icon(dir);
         }
         catch (Exception ex)
         {
            Globals.LogError(ex.ToString());
         }
         return ico;
      }
      public static void ModifyMetroUIEnabled()
      {

         MethodInfo methodToReplace = typeof(MetroFramework.Controls.MetroButton).GetMethod("Enabled",
             BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
         MethodInfo methodToInject = typeof(Injection).GetMethod("injectionMethod",
             BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
         RuntimeHelpers.PrepareMethod(methodToReplace.MethodHandle);
         RuntimeHelpers.PrepareMethod(methodToInject.MethodHandle);

         unsafe
         {
            if (IntPtr.Size == 4)
            {
               int* inj = (int*)methodToInject.MethodHandle.Value.ToPointer() + 2;
               int* tar = (int*)methodToReplace.MethodHandle.Value.ToPointer() + 2;
#if DEBUG
               Console.WriteLine("\nVersion x86 Debug\n");

               byte* injInst = (byte*)*inj;
               byte* tarInst = (byte*)*tar;

               int* injSrc = (int*)(injInst + 1);
               int* tarSrc = (int*)(tarInst + 1);

               *tarSrc = (((int)injInst + 5) + *injSrc) - ((int)tarInst + 5);
#else
                    Console.WriteLine("\nVersion x86 Release\n");
                    *tar = *inj;
#endif
            }
            else
            {

               long* inj = (long*)methodToInject.MethodHandle.Value.ToPointer() + 1;
               long* tar = (long*)methodToReplace.MethodHandle.Value.ToPointer() + 1;
#if DEBUG
               Console.WriteLine("\nVersion x64 Debug\n");
               byte* injInst = (byte*)*inj;
               byte* tarInst = (byte*)*tar;


               int* injSrc = (int*)(injInst + 1);
               int* tarSrc = (int*)(tarInst + 1);

               *tarSrc = (((int)injInst + 5) + *injSrc) - ((int)tarInst + 5);
#else
                    Console.WriteLine("\nVersion x64 Release\n");
                    *tar = *inj;
#endif
            }
         }
      }
      public static string TimeSpanToString(TimeSpan t)
      {
         string shortForm = "";
         if (t.Hours > 0)
         {
            shortForm += string.Format("{0}h", t.Hours.ToString());
         }
         if (t.Minutes > 0)
         {
            shortForm += string.Format("{0}m", t.Minutes.ToString());
         }
         if (t.Seconds > 0)
         {
            shortForm += string.Format("{0}s", t.Seconds.ToString());
         }
         if (t.Milliseconds > 0)
         {
            shortForm += string.Format("{0}ms", t.Milliseconds.ToString());
         }
         return shortForm;
      }
      public static void SetTooltip(List<Control> ctls, Phrase p, int show_duration = 3000)
      {
         foreach (Control c in ctls)
         {
            SetTooltip(c, p, show_duration);
         }
      }
      public static void SetTooltip(Control ctl, Phrase p, int show_duration = 3000)
      {
         MetroFramework.Components.MetroToolTip t = new MetroFramework.Components.MetroToolTip();
         t.ReshowDelay = 1000;
         t.Theme = Globals.MainForm.OptionsFile.Theme;
         t.UseFading = false;
         t.AutoPopDelay = show_duration;
         t.InitialDelay = 1000;
         t.IsBalloon = false;
         t.SetToolTip(ctl, Translator.Translate(p, Globals.MainForm.OptionsFile.SelectedLanguage));
      }

      [DllImport("shell32.dll", SetLastError = true)]
      public static extern int SHOpenFolderAndSelectItems(IntPtr pidlFolder, uint cidl, [In, MarshalAs(UnmanagedType.LPArray)] IntPtr[] apidl, uint dwFlags);

      [DllImport("shell32.dll", SetLastError = true)]
      public static extern void SHParseDisplayName([MarshalAs(UnmanagedType.LPWStr)] string name,
          IntPtr bindingContext, [Out] out IntPtr pidl, uint sfgaoIn, [Out] out uint psfgaoOut);

      public static void OpenFolderAndSelectItem(string folderPath, string file)
      {
         //https://stackoverflow.com/questions/334630/opening-a-folder-in-explorer-and-selecting-a-file
         IntPtr nativeFolder;
         uint psfgaoOut;
         SHParseDisplayName(folderPath, IntPtr.Zero, out nativeFolder, 0, out psfgaoOut);

         if (nativeFolder == IntPtr.Zero)
         {
            // Log error, can't find folder
            return;
         }

         IntPtr nativeFile;
         SHParseDisplayName(Path.Combine(folderPath, file), IntPtr.Zero, out nativeFile, 0, out psfgaoOut);

         IntPtr[] fileArray;
         if (nativeFile == IntPtr.Zero)
         {
            // Open the folder without the file selected if we can't find the file
            fileArray = new IntPtr[0];
         }
         else
         {
            fileArray = new IntPtr[] { nativeFile };
         }

         SHOpenFolderAndSelectItems(nativeFolder, (uint)fileArray.Length, fileArray, 0);

         Marshal.FreeCoTaskMem(nativeFolder);
         if (nativeFile != IntPtr.Zero)
         {
            Marshal.FreeCoTaskMem(nativeFile);
         }
      }


      public static void ExpandOrCollapseFormLevelControl(MetroForm form, Control toCollapse)
      {
         //Collapse a top-level form control and resize the form.
         int amt = toCollapse.Height;
         if (!toCollapse.Visible)
         {
            amt = -amt;
         }
         form.Height += amt;

         //Move up all unanchored top-level controls below this one.
         List<Control> conts = GetAllUnanchoredControlsBelow(form, toCollapse);
         foreach (Control cont in conts)
         {
            cont.Location = new Point(cont.Location.X, cont.Location.Y + amt);
         }
      }
      public static List<Control> GetAllUnanchoredControlsBelow(MetroForm form, Control below)
      {
         List<Control> ret = new List<Control>();
         int py = below.Location.Y;
         foreach (Control x in form.Controls)
         {
            if (x != null)
            {
               if (x.Anchor == AnchorStyles.None)
               {
                  if (x.Location.Y > py)
                  {
                     ret.Add(x);
                  }
               }
            }
         }
         return ret;
      }
      public static string GetAssemblyDirectory()
      {
         string ret = "";
         try
         {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            ret = Path.GetDirectoryName(path);
         }
         catch (Exception ex)
         {
            Globals.LogError(ex.ToString());
         }
         return ret;
      }
   }


}