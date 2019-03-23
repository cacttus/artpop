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
            Globals.MainForm.SettingsForm.Log(st);

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
            if(c is MetroFramework.Controls.MetroButton)
            {
                c.EnabledChanged += (s, e) => {
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
            foreach (Control cc in c.Controls) {
                RegisterExtensions(cc);
            }
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
    }


}