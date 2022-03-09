
namespace Prog3
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
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.entreeInput = new System.Windows.Forms.TextBox();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.initialCostOutput = new System.Windows.Forms.Label();
            this.adjustedCostOutput = new System.Windows.Forms.Label();
            this.shipmentCostOutput = new System.Windows.Forms.Label();
            this.totalPriceOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entree/Item Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity (Servings):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Initial Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adjusted Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shipment Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Price:";
            // 
            // cityCB
            // 
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(145, 33);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(121, 21);
            this.cityCB.TabIndex = 7;
            // 
            // entreeInput
            // 
            this.entreeInput.Location = new System.Drawing.Point(145, 60);
            this.entreeInput.Name = "entreeInput";
            this.entreeInput.Size = new System.Drawing.Size(121, 20);
            this.entreeInput.TabIndex = 8;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(145, 87);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(121, 20);
            this.quantityInput.TabIndex = 9;
            // 
            // initialCostOutput
            // 
            this.initialCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialCostOutput.Location = new System.Drawing.Point(145, 154);
            this.initialCostOutput.Name = "initialCostOutput";
            this.initialCostOutput.Size = new System.Drawing.Size(121, 23);
            this.initialCostOutput.TabIndex = 10;
            // 
            // adjustedCostOutput
            // 
            this.adjustedCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adjustedCostOutput.Location = new System.Drawing.Point(145, 182);
            this.adjustedCostOutput.Name = "adjustedCostOutput";
            this.adjustedCostOutput.Size = new System.Drawing.Size(121, 23);
            this.adjustedCostOutput.TabIndex = 11;
            // 
            // shipmentCostOutput
            // 
            this.shipmentCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipmentCostOutput.Location = new System.Drawing.Point(145, 210);
            this.shipmentCostOutput.Name = "shipmentCostOutput";
            this.shipmentCostOutput.Size = new System.Drawing.Size(121, 23);
            this.shipmentCostOutput.TabIndex = 12;
            // 
            // totalPriceOutput
            // 
            this.totalPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutput.Location = new System.Drawing.Point(145, 238);
            this.totalPriceOutput.Name = "totalPriceOutput";
            this.totalPriceOutput.Size = new System.Drawing.Size(121, 23);
            this.totalPriceOutput.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalPriceOutput);
            this.Controls.Add(this.shipmentCostOutput);
            this.Controls.Add(this.adjustedCostOutput);
            this.Controls.Add(this.initialCostOutput);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.entreeInput);
            this.Controls.Add(this.cityCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "uThankItWeMakeIt Cost Calculator";
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
        private System.Windows.Forms.ComboBox cityCB;
        private System.Windows.Forms.TextBox entreeInput;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.Label initialCostOutput;
        private System.Windows.Forms.Label adjustedCostOutput;
        private System.Windows.Forms.Label shipmentCostOutput;
        private System.Windows.Forms.Label totalPriceOutput;
        private System.Windows.Forms.Button button1;
    }
}

