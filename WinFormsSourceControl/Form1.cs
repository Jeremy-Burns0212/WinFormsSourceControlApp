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
        int length = Convert.ToInt32(txtLength.Text);
        int width = Convert.ToInt32(txtWidth.Text);

        int area = length * width;
        int perimeter = 2 * (length + width);

        txtArea.Text = "Area is: " + area;
        txtPerimeter.Text = "Perimeter is: " + perimeter;
		    }
}