
namespace Program_2
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.companyAOutput = new System.Windows.Forms.Label();
            this.companyBOutput = new System.Windows.Forms.Label();
            this.CompanyCOutput = new System.Windows.Forms.Label();
            this.lowestCostOutput = new System.Windows.Forms.Label();
            this.passInput = new System.Windows.Forms.TextBox();
            this.DistInput = new System.Windows.Forms.TextBox();
            this.CarTypeCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passengers (1-12):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Distance (Miles):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Car Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Company A Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Company B Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Company C Cost";
            // 
            // companyAOutput
            // 
            this.companyAOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyAOutput.Location = new System.Drawing.Point(413, 53);
            this.companyAOutput.Name = "companyAOutput";
            this.companyAOutput.Size = new System.Drawing.Size(100, 20);
            this.companyAOutput.TabIndex = 13;
            this.companyAOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyBOutput
            // 
            this.companyBOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyBOutput.Location = new System.Drawing.Point(413, 109);
            this.companyBOutput.Name = "companyBOutput";
            this.companyBOutput.Size = new System.Drawing.Size(100, 20);
            this.companyBOutput.TabIndex = 14;
            this.companyBOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyCOutput
            // 
            this.CompanyCOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyCOutput.Location = new System.Drawing.Point(413, 171);
            this.CompanyCOutput.Name = "CompanyCOutput";
            this.CompanyCOutput.Size = new System.Drawing.Size(100, 20);
            this.CompanyCOutput.TabIndex = 15;
            this.CompanyCOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowestCostOutput
            // 
            this.lowestCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestCostOutput.Location = new System.Drawing.Point(323, 235);
            this.lowestCostOutput.Name = "lowestCostOutput";
            this.lowestCostOutput.Size = new System.Drawing.Size(190, 20);
            this.lowestCostOutput.TabIndex = 16;
            this.lowestCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(121, 55);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(100, 20);
            this.passInput.TabIndex = 18;
            // 
            // DistInput
            // 
            this.DistInput.Location = new System.Drawing.Point(121, 110);
            this.DistInput.Name = "DistInput";
            this.DistInput.Size = new System.Drawing.Size(100, 20);
            this.DistInput.TabIndex = 19;
            // 
            // CarTypeCB
            // 
            this.CarTypeCB.FormattingEnabled = true;
            this.CarTypeCB.Location = new System.Drawing.Point(121, 171);
            this.CarTypeCB.Name = "CarTypeCB";
            this.CarTypeCB.Size = new System.Drawing.Size(100, 21);
            this.CarTypeCB.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(92, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calculate Cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(278, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 253);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CarTypeCB);
            this.Controls.Add(this.DistInput);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.lowestCostOutput);
            this.Controls.Add(this.CompanyCOutput);
            this.Controls.Add(this.companyBOutput);
            this.Controls.Add(this.companyAOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "IRydeShare Cost Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label companyAOutput;
        private System.Windows.Forms.Label companyBOutput;
        private System.Windows.Forms.Label CompanyCOutput;
        private System.Windows.Forms.Label lowestCostOutput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.TextBox DistInput;
        private System.Windows.Forms.ComboBox CarTypeCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

