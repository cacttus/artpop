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
namespace ArtPop
{
    public partial class HelpForm : MetroForm
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            _txtHelp.Text = "About:\r\n";
            _txtHelp.Text = "ArtPop is a structured practice environment for drawers and artists aimed towards helping you master capturing form." +
                "\r\n\r\n" ;

            _txtHelp.Text += "How To Use:\r\n";
            _txtHelp.Text += "The program starts with a default practice session selected in the main form.  " +
                "To run the default session, you need to first set up a place where the program can pull images from. "+ 
                "Go to the Settings (Gear) icon and go to the 'Search Path' box.  Select a folder where the program should search for images. " +
                " Ideally you'll have a lot of practice images in this folder (I have about 50,000 images)." +
                "\r\n" +
                "Once you've selected a folder, click the Search button.  " +
                "This may take some time." +
                "\r\n" +
                "When the search completes, Save this window and get your drawing supplies ready.  Click the Play button on the main window to start.  " +
                "You'll see your image appear in a new window for a period of time along with the instruction of what to draw." +
                "a practice session." +
                "\r\n\r\n";
            _txtHelp.Text += " The default session isn't probably going to be what you want.  So you can create your own practice sessions by clicking the little box icon on the main form.  " +
                "" +
                "In the session you will want to add exercises.  Exercises are the tasks you do " +
                "during a practice session.  For me I create speed draw 2 minutes, 5 minutes, then add a couple of those.\r\n\r\n";
            _txtHelp.Text += "  Once your practice session is created you can go through it again by selecting it in the combo box on the main form, then clicking the Play button.\r\n";
            _txtHelp.Text += "\r\n";
            _txtHelp.Text += "Note: You can exclude a bad image by Pressing 'E' and it will never show up again unless you clear the cache of bad images in the settings.";
            _txtHelp.Text += "\r\n\r\n";
            _txtHelp.Text += "Shortcuts:\r\n";
            _txtHelp.Text += "  Spacebar - skip image";
            _txtHelp.Text += "  Right Arrow - next ";
            _txtHelp.Text += "  Left Arrow - prev";
            _txtHelp.Text += "  E - Exclude Image";
            _txtHelp.Text += "  Esc - Toggle Fullscreen";


            _txtLicense.Text = "Copyright 2018, 2019 Derek Page";
            _txtLicense.Text += "\r\n\r\n";
            _txtLicense.Text += "Permission is hereby granted, free of charge, to any person obtaining a copy of this software and " +
                "associated documentation files(the \"Software\"), to deal in the Software without restriction, including without limitation" +
                " the rights to use, copy, modify, merge, publish, distribute, sublicense, and/ or sell copies of the Software, and to permit " +
                "persons to whom the Software is furnished to do so, subject to the following conditions: ";
            _txtLicense.Text += "\r\n\r\n";
            _txtLicense.Text += "The above copyright notice and this permission notice shall be included in all " +
                "copies or substantial portions of the Software.";
            _txtLicense.Text += "\r\n\r\n";
            _txtLicense.Text += "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED," +
                " INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE" +
                " AND NONINFRINGEMENT.IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, " +
                "DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR" +
                " IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.";

            _txtAbout.Text = "";
            _txtAbout.Text += "Written By Derek Page\r\n";
            _txtAbout.Text += "Build Date: 02.24.2019\r\n";
            _txtAbout.Text += "Program Version: " + Globals.ProgramVersion + "\r\n";
            _txtAbout.Text += "Settings File Version: " + Globals.SettingsFileVersion + "\r\n";

        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
