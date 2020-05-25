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
using MetroFramework.Interfaces;
using MetroFramework.Components;
using MetroFramework.Controls;
using System.Reflection;

namespace ArtPop
{
    public partial class MonoEditForm : MetroForm
    {
        public MetroStyleManager MetroStyleManager { get; private set; }
        public MonoEditForm()
        {
            InitializeComponent();
        }
        private void MonoEditForm_Load(object sender, EventArgs e)
        {
            //  Don't apply styles here for sake of usercontrols and dynamic controls.
        }
        private void MonoEditForm_Shown(object sender, EventArgs e)
        {
            ApplyStyle();
            try
            {
                Icon = Globals.LoadIconResource("ArtPopLogo256.ico");
            }
            catch (Exception ex)
            {
                Globals.LogError("Couldn't find icon ");
            }
        }
        public void ApplyStyle()
        {
            MetroStyleManager = new MetroStyleManager(new Container());
            MetroStyleManager.Owner = this;
            if (Globals.MainForm != null && Globals.MainForm.OptionsFile != null)
            {

                MetroStyleManager.Theme = Globals.MainForm.OptionsFile.Theme;
            }
            else
            {
                MetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            Theme = MetroStyleManager.Theme;

            ApplyStyle(this);

            Refresh();
        }
        protected void ApplyStyle(Control parent, MetroStyleManager manager = null)
        {
            if (manager == null)
            {
                manager = MetroStyleManager;
            }

            //Call this to apply the same style to the prevoisu parent.s
            if (parent != null)
            {

                if (parent as MetroUserControl != null)
                {
                    //Usercontrols have custom back colors.
                    int n = 0;
                    n++;
                }
                if (parent as IMetroControl != null)
                {
                    if (manager != null)
                    {
                        (parent as IMetroControl).Theme = manager.Theme;
                        parent.Refresh();
                    }
                }
                else if (parent as RichTextBox != null)
                {
                    //Most basic windows controls will require something like this
                    parent.ForeColor = ThemeApplier.MenuForeColor();
                    parent.BackColor = ThemeApplier.MenuBackColor();
                }
                else if (parent as MenuStrip != null)
                {
                    SetMenuColor(parent as MenuStrip);
                }
                else if (parent.GetType().GetProperty("Theme") != null)
                {
                    MetroFramework.MetroThemeStyle? txt =
                        parent.GetType().GetProperty("Theme").GetValue(parent, null) as MetroFramework.MetroThemeStyle?;

                    if (txt != null)
                    {
                        parent.GetType().InvokeMember("Theme",
                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                            Type.DefaultBinder, parent, new object[] { manager.Theme });
                    }
                }
                //Not sure why metrobutton isn't getting set.  
                //Generic "Text" Property translation
            }

            foreach (Control c in parent.Controls)
            {
                ApplyStyle(c, manager);
            }
        }
        void SetMenuColor(MenuStrip ms)
        {
            foreach (ToolStripItem m in ms.Items)
            {
                ToolStripItem m_conv = m as ToolStripItem;

                if (m_conv != null)
                {
                    SetMenuColor(m_conv);
                }
            }
            ms.ForeColor = ThemeApplier.MenuForeColor();
            ms.BackColor = ThemeApplier.MenuBackColor();
        }
        void SetMenuColor(ToolStripItem m)
        {
            if (m != null)
            {
                //ToolStripMenuItem mi = m as ToolStripMenuItem;
                m.ForeColor = ThemeApplier.MenuForeColor();
                m.BackColor = ThemeApplier.MenuBackColor();
                if (m as ToolStripMenuItem != null)
                {
                    //Recursively set children
                    foreach (ToolStripItem m2 in (m as ToolStripMenuItem).DropDownItems)
                    {
                        ToolStripItem m_conv = m2 as ToolStripItem;
                        if (m_conv != null)
                        {
                            SetMenuColor(m_conv);
                        }
                    }
                }
            }

        }



    }
}
