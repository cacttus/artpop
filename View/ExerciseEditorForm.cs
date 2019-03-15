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
    public partial class ExerciseEditorForm : MetroForm
    {

        public Exercise Exercise { get; set; }


        public AddEditMode AddEditMode { get; private set; }
        public ExerciseEditorForm(AddEditMode mode, Exercise ex)
        {
            InitializeComponent();
            this.AddEditMode = mode;
            if (ex == null)
            {
                if (AddEditMode == AddEditMode.Add)
                {
                    Exercise = new Exercise();
                }
                else
                {
                    Globals.LogError("Error: Exercise was null for edit.");
                }
            }
            else
            {
                if(AddEditMode == AddEditMode.Edit)
                {
                    Exercise = ex;
                    LoadData();
                }
                else
                {
                    Globals.LogError("Error: Exercise was NOT null for add.");

                }
            }
        }

        private void MarkChanged(bool b)
        {
            _btnApply.Enabled = b;
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            SaveData();
            DialogResult = DialogResult.OK;
        }

        private void _btnApply_Click(object sender, EventArgs e)
        {
            SaveData();
            MarkChanged(false);
            DialogResult = DialogResult.OK;
        }
        private void _btnCancel_Click(object sender, EventArgs e)
        {
            //User has't previously clicked "Apply"
            if(DialogResult!= DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void ExerciseEditorForm_Load(object sender, EventArgs e)
        {
            if (this.AddEditMode == AddEditMode.Add)
            {
                _btnApply.Visible = false;
                int d = _btnApply.Location.X + _btnApply.Width / 2;
                int pad = (int)(_btnApply.Width * 0.3 / 2);

                _btnOk.Location = new Point(d - _btnOk.Width - pad, _btnOk.Location.Y);
                _btnCancel.Location = new Point(d + pad, _btnCancel.Location.Y);
            }
        }
        public int DtpToMillis()
        {
            //We're just using the h/m/s of the DTP
            return _dtpTime.Value.Hour * 60 * 60 * 1000 + _dtpTime.Value.Minute * 60 * 1000 + _dtpTime.Value.Second * 1000;
        }

        public void SaveData()
        {
            Exercise.Name = _txtName.Text;
            Exercise.Duration = TimeSpan.FromMilliseconds(DtpToMillis());
            Exercise.Instruction = _txtInstruction.Text;
            Exercise.Difficulty = _cboDifficulty.SelectedText;
        }
        public void LoadData()
        {
            _txtName.Text = Exercise.Name;
            _txtInstruction.Text = Exercise.Instruction;
            _cboDifficulty.SelectedText = Exercise.Difficulty;
            _dtpTime.Value = new DateTime(2012, 01, 01) + Exercise.Duration;
        }



        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkChanged(true);
        }

        private void _dtpTime_ValueChanged(object sender, EventArgs e)
        {
            MarkChanged(true);

        }

        private void _txtInstruction_Click(object sender, EventArgs e)
        {
            MarkChanged(true);

        }

        private void _txtInstruction_TextChanged(object sender, EventArgs e)
        {
            MarkChanged(true);

        }

        private void _txtName_TextChanged(object sender, EventArgs e)
        {
            MarkChanged(true);

        }
    }
}
