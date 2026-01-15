using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSourceControl;


public partial class Form1 : Form
{
    public Form1()
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
}