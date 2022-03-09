
namespace Lab_4
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
            this.GPA = new System.Windows.Forms.TextBox();
            this.TestScoreInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalAcceptedAmount = new System.Windows.Forms.Label();
            this.TotalRejectedAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade Point Average:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Accepted:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Rejected:";
            // 
            // GPA
            // 
            this.GPA.Location = new System.Drawing.Point(162, 24);
            this.GPA.Name = "GPA";
            this.GPA.Size = new System.Drawing.Size(100, 20);
            this.GPA.TabIndex = 4;
            // 
            // TestScoreInput
            // 
            this.TestScoreInput.Location = new System.Drawing.Point(162, 63);
            this.TestScoreInput.Name = "TestScoreInput";
            this.TestScoreInput.Size = new System.Drawing.Size(100, 20);
            this.TestScoreInput.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalAcceptedAmount
            // 
            this.TotalAcceptedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalAcceptedAmount.Location = new System.Drawing.Point(100, 110);
            this.TotalAcceptedAmount.Name = "TotalAcceptedAmount";
            this.TotalAcceptedAmount.Size = new System.Drawing.Size(100, 23);
            this.TotalAcceptedAmount.TabIndex = 7;
            this.TotalAcceptedAmount.Click += new System.EventHandler(this.TotalAcceptedAmount_Click);
            // 
            // TotalRejectedAmount
            // 
            this.TotalRejectedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalRejectedAmount.Location = new System.Drawing.Point(293, 109);
            this.TotalRejectedAmount.Name = "TotalRejectedAmount";
            this.TotalRejectedAmount.Size = new System.Drawing.Size(100, 23);
            this.TotalRejectedAmount.TabIndex = 8;
            this.TotalRejectedAmount.Click += new System.EventHandler(this.TotalRejectedAmount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 188);
            this.Controls.Add(this.TotalRejectedAmount);
            this.Controls.Add(this.TotalAcceptedAmount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TestScoreInput);
            this.Controls.Add(this.GPA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GPA;
        private System.Windows.Forms.TextBox TestScoreInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalAcceptedAmount;
        private System.Windows.Forms.Label TotalRejectedAmount;
    }
}

