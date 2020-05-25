using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using MetroFramework;

namespace ArtPop
{
    /// <summary>
    /// Applies themes generally to MetroUI controls.
    /// </summary>
    public static class ThemeApplier
    {
        public static Color MenuColorBackDark = Color.FromArgb(255, 64, 64, 64);
        public static Color MenuColorForeDark = Color.FromArgb(255, 224, 224, 224);

        public static Color MenuColorBackLight = Color.FromArgb(255, 224, 224, 224);
        public static Color MenuColorForeLight = Color.FromArgb(255, 17, 17, 17);

        public static Color EditorBackLight = Color.FromArgb(255, 255, 255, 255);
        public static Color EditorBackDark = Color.FromArgb(255, 35, 37, 39);

        public static Color EditorTextLight = Color.FromArgb(255, 12, 12, 12);
        public static Color EditorTextDark = Color.FromArgb(255, 233, 233, 233);

        public static Color StringDark = Color.FromArgb(245, 88, 135);
        public static Color StringLight = Color.FromArgb(168, 21, 77);

        public static Color NumberDark = Color.FromArgb(124, 243, 131);
        public static Color NumberLight = Color.FromArgb(17, 71, 7);

        //public static void SetBackgroundImage(Control a, string name, bool greyOut = false)
        //{
        //    //greyOut is used to show "disabled" images (in our limited set).
        //    Bitmap bmp = Globals.LoadThemedBitmapResource(name);
        //    if (greyOut)
        //    {
        //        new ImageMaker(bmp).Colorize(new Pixel(128, 128, 128, 255));
        //    }
        //    a.BackgroundImage = bmp;
        //    a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        //}
        public static Color EditorTextColor()
        {
            return SelectColorByTheme(EditorTextLight, EditorTextDark);
        }
        public static Color EditorBackColor()
        {
            return SelectColorByTheme(EditorBackLight, EditorBackDark);
        }
        public static Color StringColor()
        {
            return SelectColorByTheme(StringLight, StringDark);
        }
        public static Color NumberColor()
        {
            return SelectColorByTheme(NumberLight, NumberDark);
        }
        public static Color MenuForeColor()
        {
            return SelectColorByTheme(MenuColorForeLight, MenuColorForeDark);
        }
        public static Color MenuBackColor()
        {
            return SelectColorByTheme(MenuColorBackLight, MenuColorBackDark);
        }
        public static Color SelectColorByTheme(Color light, Color dark)
        {
            if (Globals.MainForm != null && Globals.MainForm.OptionsFile != null)
            {
                if (Globals.MainForm.OptionsFile.Theme == MetroThemeStyle.Dark)
                {
                    return dark;
                }
                else
                {
                    return light;
                }
            }
            return dark;
        }

        public static void SwitchTheme(MetroFramework.MetroThemeStyle theme)
        {
            Globals.MainForm.OptionsFile.Theme = theme;
            Globals.MainForm.ApplyStyle();
            foreach (MonoEditForm f in Globals.MainForm.Forms)
            {
                f.ApplyStyle();
            }
        }


    }

}
