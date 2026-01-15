using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSourceControl
{


    public partial class AreaAndPerimeterCalculator : Form
    {
        public AreaAndPerimeterCalculator()
        {
            InitializeComponent();
        }

        private void btnCalcAreaAndPerimeter_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLength.Text, out int length))
            {
                MessageBox.Show("Please enter a valid integer for length.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtWidth.Text, out int width))
            {
                MessageBox.Show("Please enter a valid integer for width.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int area = length * width;
            int perimeter = 2 * (length + width);

            txtArea.Text = "Area is: " + area;
            txtPerimeter.Text = "Perimeter is: " + perimeter;
        }

        private void AreaAndPerimeterCalculator_Load(object sender, EventArgs e)
        {

        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            // Checked = dark mode, Unchecked = light mode
            ApplyTheme(chkDarkMode.Checked);
        }

        private void ApplyTheme(bool isDarkMode)
        {
            this.BackColor = isDarkMode ? Color.Black : SystemColors.Control;
            lblLength.ForeColor = isDarkMode ? Color.White : Color.Black;
            lblWidth.ForeColor = isDarkMode ? Color.White : Color.Black;
            txtLength.BackColor = isDarkMode ? Color.Gray : Color.White;
            txtWidth.BackColor = isDarkMode ? Color.Gray : Color.White;
            btnCalcAreaAndPerimeter.BackColor = isDarkMode ? Color.DarkGray : SystemColors.Control;
            txtArea.BackColor = isDarkMode ? Color.Gray : Color.White;
            txtPerimeter.BackColor = isDarkMode ? Color.Gray : Color.White;
            chkDarkMode.ForeColor = isDarkMode ? Color.White : Color.Black;
            chkDarkMode.BackColor = isDarkMode ? Color.Gray : SystemColors.Control;
        }
    }
}