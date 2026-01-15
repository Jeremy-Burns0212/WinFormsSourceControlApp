namespace WinFormsSourceControl
{
    partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.btnCalcAreaAndPerimeter = new System.Windows.Forms.Button();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.txtPerimeter = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Length";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Width";
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
			this.txtArea.Location = new System.Drawing.Point(313, 137);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtPerimeter);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.btnCalcAreaAndPerimeter);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.txtLength);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalcAreaAndPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
    }
}

