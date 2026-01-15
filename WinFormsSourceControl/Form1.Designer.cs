namespace WinFormsSourceControl
{
    partial class AreaAndPerimeterCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblLength = new System.Windows.Forms.Label();
			this.lblWidth = new System.Windows.Forms.Label();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.btnCalcAreaAndPerimeter = new System.Windows.Forms.Button();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.txtPerimeter = new System.Windows.Forms.TextBox();
			this.chkDarkMode = new System.Windows.Forms.CheckBox();
			this.cboLengthUnit = new System.Windows.Forms.ComboBox();
			this.cboWidthUnit = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblLength
			// 
			this.lblLength.AutoSize = true;
			this.lblLength.Location = new System.Drawing.Point(45, 65);
			this.lblLength.Name = "lblLength";
			this.lblLength.Size = new System.Drawing.Size(59, 20);
			this.lblLength.TabIndex = 0;
			this.lblLength.Text = "Length";
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(45, 108);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(50, 20);
			this.lblWidth.TabIndex = 1;
			this.lblWidth.Text = "Width";
			// 
			// txtLength
			// 
			this.txtLength.Location = new System.Drawing.Point(164, 65);
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(100, 26);
			this.txtLength.TabIndex = 2;
			// 
			// txtWidth
			// 
			this.txtWidth.Location = new System.Drawing.Point(164, 105);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(100, 26);
			this.txtWidth.TabIndex = 3;
			// 
			// btnCalcAreaAndPerimeter
			// 
			this.btnCalcAreaAndPerimeter.Location = new System.Drawing.Point(49, 163);
			this.btnCalcAreaAndPerimeter.Name = "btnCalcAreaAndPerimeter";
			this.btnCalcAreaAndPerimeter.Size = new System.Drawing.Size(215, 83);
			this.btnCalcAreaAndPerimeter.TabIndex = 4;
			this.btnCalcAreaAndPerimeter.Text = "Calculate Area and Perimeter";
			this.btnCalcAreaAndPerimeter.UseVisualStyleBackColor = true;
			this.btnCalcAreaAndPerimeter.Click += new System.EventHandler(this.btnCalcAreaAndPerimeter_Click);
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(313, 163);
			this.txtArea.Name = "txtArea";
			this.txtArea.ReadOnly = true;
			this.txtArea.Size = new System.Drawing.Size(162, 26);
			this.txtArea.TabIndex = 5;
			// 
			// txtPerimeter
			// 
			this.txtPerimeter.Location = new System.Drawing.Point(313, 220);
			this.txtPerimeter.Name = "txtPerimeter";
			this.txtPerimeter.ReadOnly = true;
			this.txtPerimeter.Size = new System.Drawing.Size(162, 26);
			this.txtPerimeter.TabIndex = 6;
			// 
			// chkDarkMode
			// 
			this.chkDarkMode.AutoSize = true;
			this.chkDarkMode.Location = new System.Drawing.Point(443, 12);
			this.chkDarkMode.Name = "chkDarkMode";
			this.chkDarkMode.Size = new System.Drawing.Size(214, 24);
			this.chkDarkMode.TabIndex = 7;
			this.chkDarkMode.Text = "Dark Theme/Light Theme";
			this.chkDarkMode.UseVisualStyleBackColor = true;
			this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
			// 
			// cboLengthUnit
			// 
			this.cboLengthUnit.FormattingEnabled = true;
			this.cboLengthUnit.Location = new System.Drawing.Point(286, 62);
			this.cboLengthUnit.Name = "cboLengthUnit";
			this.cboLengthUnit.Size = new System.Drawing.Size(67, 28);
			this.cboLengthUnit.TabIndex = 8;
			this.cboLengthUnit.SelectedIndexChanged += new System.EventHandler(this.cboLengthUnit_SelectedIndexChanged);
			// 
			// cboWidthUnit
			// 
			this.cboWidthUnit.FormattingEnabled = true;
			this.cboWidthUnit.Location = new System.Drawing.Point(286, 105);
			this.cboWidthUnit.Name = "cboWidthUnit";
			this.cboWidthUnit.Size = new System.Drawing.Size(67, 28);
			this.cboWidthUnit.TabIndex = 9;
			this.cboWidthUnit.SelectedIndexChanged += new System.EventHandler(this.cboWidthUnit_SelectedIndexChanged);
			// 
			// AreaAndPerimeterCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 297);
			this.Controls.Add(this.cboWidthUnit);
			this.Controls.Add(this.cboLengthUnit);
			this.Controls.Add(this.chkDarkMode);
			this.Controls.Add(this.txtPerimeter);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.btnCalcAreaAndPerimeter);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.txtLength);
			this.Controls.Add(this.lblWidth);
			this.Controls.Add(this.lblLength);
			this.Name = "AreaAndPerimeterCalculator";
			this.Text = "Area And Perimeter Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalcAreaAndPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.ComboBox cboLengthUnit;
        private System.Windows.Forms.ComboBox cboWidthUnit;
    }
}

