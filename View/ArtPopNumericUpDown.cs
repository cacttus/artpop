using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtPop
{
    public enum DataType {
        Double,
        Int32
    }

    public partial class ArtPopNumericUpDown : MetroFramework.Controls.MetroUserControl
    {
        static int boobs = 1;

        int my_boob = 0;
        public ArtPopNumericUpDown()
        {
            InitializeComponent();
            my_boob = boobs++;
        }
        public DataType DataType { get; set; } = DataType.Double;
        public Action ValueChanged { get; set; } = null;
        public double Min { get; set; } = 0;
        public double Max { get; set; } = 100;
        public double Value2
        {
            get
            {
                double n = 0;
                Double.TryParse(_txtValue.Text, out n);
                return n;
            }
            set
            {
                _txtValue.Text = value.ToString();
                _txtValue.Refresh();
            }
        }

        private void MonoEditNumericUpDown_Load(object sender, EventArgs e)
        {

        }

        private void _btnUp_Click(object sender, EventArgs e)
        {
           // Invalidate();
          //  Refresh();
            double n = 0;
            if (Double.TryParse(_txtValue.Text, out n))
            {
                n = CheckRange(n + 1);
                Value2 = n;
                //_txtValue.Text = n.ToString();
            }

        }
        private double CheckRange(double n)
        {
            if (n > Max) n = Max;
            if (n < Min) n = Min;
            return n;
        }
        private void _btnDown_Click(object sender, EventArgs e)
        {
          //  Invalidate();
           // Refresh();
            double n = 0;
            if (double.TryParse(_txtValue.Text, out n))
            {
                n = CheckRange(n - 1);
                Value2 = n;
                //_txtValue.Text = n.ToString();
            }
        }
        private void _txtValue_Click(object sender, EventArgs e)
        {
        }
        private void _txtValue_TextChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke();
        }
        private void _txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (DataType == DataType.Double && e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            MetroFramework.Controls.MetroTextBox mt = (sender as MetroFramework.Controls.MetroTextBox);
            if (mt != null)
            {
                if (( (DataType == DataType.Double) && (e.KeyChar == '.') && (mt.Text.IndexOf('.') > -1)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
