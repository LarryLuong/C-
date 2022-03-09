
namespace Program_1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.YardsOutput = new System.Windows.Forms.Label();
            this.MatCostOutput = new System.Windows.Forms.Label();
            this.ExcavCostOutput = new System.Windows.Forms.Label();
            this.LaborCostOutput = new System.Windows.Forms.Label();
            this.TotalCostOutput = new System.Windows.Forms.Label();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.LengthInput = new System.Windows.Forms.TextBox();
            this.DepthInput = new System.Windows.Forms.TextBox();
            this.MatPriceInput = new System.Windows.Forms.TextBox();
            this.ExcavInput = new System.Windows.Forms.TextBox();
            this.BoardInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EZ-Pools Costs Estimator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Width of Pool (ft):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max Length of Pool (ft):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Depth of Pool (ft):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Materials Price (cubic yd):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Excavation Needed?:\r\n          (1=YES, 0=NO)\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Diving Board?:\r\n(1=YES, 0=NO)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cubic Yards:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Materials Cost:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Excavation Cost:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Labor Cost:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(100, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total Cost:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // YardsOutput
            // 
            this.YardsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YardsOutput.Location = new System.Drawing.Point(175, 299);
            this.YardsOutput.Name = "YardsOutput";
            this.YardsOutput.Size = new System.Drawing.Size(100, 23);
            this.YardsOutput.TabIndex = 12;
            // 
            // MatCostOutput
            // 
            this.MatCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatCostOutput.Location = new System.Drawing.Point(175, 330);
            this.MatCostOutput.Name = "MatCostOutput";
            this.MatCostOutput.Size = new System.Drawing.Size(100, 23);
            this.MatCostOutput.TabIndex = 13;
            // 
            // ExcavCostOutput
            // 
            this.ExcavCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExcavCostOutput.Location = new System.Drawing.Point(175, 360);
            this.ExcavCostOutput.Name = "ExcavCostOutput";
            this.ExcavCostOutput.Size = new System.Drawing.Size(100, 23);
            this.ExcavCostOutput.TabIndex = 14;
            // 
            // LaborCostOutput
            // 
            this.LaborCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LaborCostOutput.Location = new System.Drawing.Point(175, 390);
            this.LaborCostOutput.Name = "LaborCostOutput";
            this.LaborCostOutput.Size = new System.Drawing.Size(100, 23);
            this.LaborCostOutput.TabIndex = 15;
            // 
            // TotalCostOutput
            // 
            this.TotalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCostOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostOutput.Location = new System.Drawing.Point(175, 420);
            this.TotalCostOutput.Name = "TotalCostOutput";
            this.TotalCostOutput.Size = new System.Drawing.Size(100, 23);
            this.TotalCostOutput.TabIndex = 16;
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(175, 81);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(100, 20);
            this.WidthInput.TabIndex = 17;
            // 
            // LengthInput
            // 
            this.LengthInput.Location = new System.Drawing.Point(175, 111);
            this.LengthInput.Name = "LengthInput";
            this.LengthInput.Size = new System.Drawing.Size(100, 20);
            this.LengthInput.TabIndex = 18;
            // 
            // DepthInput
            // 
            this.DepthInput.Location = new System.Drawing.Point(175, 141);
            this.DepthInput.Name = "DepthInput";
            this.DepthInput.Size = new System.Drawing.Size(100, 20);
            this.DepthInput.TabIndex = 19;
            // 
            // MatPriceInput
            // 
            this.MatPriceInput.Location = new System.Drawing.Point(175, 171);
            this.MatPriceInput.Name = "MatPriceInput";
            this.MatPriceInput.Size = new System.Drawing.Size(100, 20);
            this.MatPriceInput.TabIndex = 20;
            // 
            // ExcavInput
            // 
            this.ExcavInput.Location = new System.Drawing.Point(175, 201);
            this.ExcavInput.Name = "ExcavInput";
            this.ExcavInput.Size = new System.Drawing.Size(100, 20);
            this.ExcavInput.TabIndex = 21;
            // 
            // BoardInput
            // 
            this.BoardInput.Location = new System.Drawing.Point(175, 235);
            this.BoardInput.Name = "BoardInput";
            this.BoardInput.Size = new System.Drawing.Size(100, 20);
            this.BoardInput.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(85, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calculate Estimate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoardInput);
            this.Controls.Add(this.ExcavInput);
            this.Controls.Add(this.MatPriceInput);
            this.Controls.Add(this.DepthInput);
            this.Controls.Add(this.LengthInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.TotalCostOutput);
            this.Controls.Add(this.LaborCostOutput);
            this.Controls.Add(this.ExcavCostOutput);
            this.Controls.Add(this.MatCostOutput);
            this.Controls.Add(this.YardsOutput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label YardsOutput;
        private System.Windows.Forms.Label MatCostOutput;
        private System.Windows.Forms.Label ExcavCostOutput;
        private System.Windows.Forms.Label LaborCostOutput;
        private System.Windows.Forms.Label TotalCostOutput;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.TextBox LengthInput;
        private System.Windows.Forms.TextBox DepthInput;
        private System.Windows.Forms.TextBox MatPriceInput;
        private System.Windows.Forms.TextBox ExcavInput;
        private System.Windows.Forms.TextBox BoardInput;
        private System.Windows.Forms.Button button1;
    }
}

