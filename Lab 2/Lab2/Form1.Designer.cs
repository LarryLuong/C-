
namespace Lab2
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
            this.firstNumTxt = new System.Windows.Forms.TextBox();
            this.tip1output = new System.Windows.Forms.Label();
            this.tip2output = new System.Windows.Forms.Label();
            this.tip3output = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter price of meal:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "15%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "18%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // firstNumTxt
            // 
            this.firstNumTxt.Location = new System.Drawing.Point(190, 28);
            this.firstNumTxt.Name = "firstNumTxt";
            this.firstNumTxt.Size = new System.Drawing.Size(100, 20);
            this.firstNumTxt.TabIndex = 4;
            this.firstNumTxt.TextChanged += new System.EventHandler(this.firstNumTxt_TextChanged);
            // 
            // tip1output
            // 
            this.tip1output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tip1output.Location = new System.Drawing.Point(190, 71);
            this.tip1output.Name = "tip1output";
            this.tip1output.Size = new System.Drawing.Size(100, 23);
            this.tip1output.TabIndex = 5;
            this.tip1output.Click += new System.EventHandler(this.label5_Click);
            // 
            // tip2output
            // 
            this.tip2output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tip2output.Location = new System.Drawing.Point(190, 115);
            this.tip2output.Name = "tip2output";
            this.tip2output.Size = new System.Drawing.Size(100, 23);
            this.tip2output.TabIndex = 6;
            this.tip2output.Click += new System.EventHandler(this.label6_Click);
            // 
            // tip3output
            // 
            this.tip3output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tip3output.Location = new System.Drawing.Point(190, 159);
            this.tip3output.Name = "tip3output";
            this.tip3output.Size = new System.Drawing.Size(100, 23);
            this.tip3output.TabIndex = 8;
            this.tip3output.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "20%";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate Tip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tip3output);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tip2output);
            this.Controls.Add(this.tip1output);
            this.Controls.Add(this.firstNumTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNumTxt;
        private System.Windows.Forms.Label tip1output;
        private System.Windows.Forms.Label tip2output;
        private System.Windows.Forms.Label tip3output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

