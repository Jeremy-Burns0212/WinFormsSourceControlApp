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
            // populate unit selection comboboxes
            var units = new object[] { "in", "feet", "yard", "cm", "mm" };
            cboLengthUnit.Items.AddRange(units);
            cboWidthUnit.Items.AddRange(units);
            if (cboLengthUnit.Items.Count > 0) cboLengthUnit.SelectedIndex = 0;
            if (cboWidthUnit.Items.Count > 0) cboWidthUnit.SelectedIndex = 0;
        }

        private void btnCalcAreaAndPerimeter_Click(object sender, EventArgs e)
        {
            // parse inputs as doubles
            if (!double.TryParse(txtLength.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double length))
            {
                MessageBox.Show("Please enter a valid number for length.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtWidth.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double width))
            {
                MessageBox.Show("Please enter a valid number for width.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // determine selected units (fallback to inches if null)
            string lengthUnit = (cboLengthUnit.SelectedItem as string) ?? "in";
            string widthUnit = (cboWidthUnit.SelectedItem as string) ?? "in";

            // convert both measurements to meters for consistent math
            double lengthMeters = ConvertToMeters(length, lengthUnit);
            double widthMeters = ConvertToMeters(width, widthUnit);

            double areaSquareMeters = lengthMeters * widthMeters;
            double perimeterMeters = 2 * (lengthMeters + widthMeters);

            // show results in metric (meters / square meters) with 3 decimal places
            txtArea.Text = "Area: " + areaSquareMeters.ToString("F3", System.Globalization.CultureInfo.InvariantCulture) + " m²";
            txtPerimeter.Text = "Perimeter: " + perimeterMeters.ToString("F3", System.Globalization.CultureInfo.InvariantCulture) + " m";
        }

        private double ConvertToMeters(double value, string unit)
        {
            if (string.IsNullOrWhiteSpace(unit)) return value * 0.0254; // default inches
            switch (unit.Trim().ToLowerInvariant())
            {
                case "in":
                case "inch":
                case "inches":
                    return value * 0.0254; // 1 inch = 0.0254 m
                case "feet":
                case "ft":
                case "foot":
                    return value * 0.3048; // 1 ft = 0.3048 m
                case "yard":
                case "yards":
                    return value * 0.9144; // 1 yard = 0.9144 m
                case "cm":
                case "centimeter":
                case "centimeters":
                    return value * 0.01; // 1 cm = 0.01 m
                case "mm":
                case "millimeter":
                case "millimeters":
                    return value * 0.001; // 1 mm = 0.001 m
                default:
                    // unknown unit: assume meters
                    double parsed;
                    if (double.TryParse(unit, out parsed)) return value * parsed;
                    return value; // treat as meters
            }
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

        private void cboLengthUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboWidthUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}