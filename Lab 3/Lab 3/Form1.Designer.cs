
namespace Lab_3
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
            this.sphereRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiameterOutput = new System.Windows.Forms.Label();
            this.SurfaceAreaOutput = new System.Windows.Forms.Label();
            this.VolumeOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius of sphere:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sphereRadius
            // 
            this.sphereRadius.Location = new System.Drawing.Point(258, 67);
            this.sphereRadius.Name = "sphereRadius";
            this.sphereRadius.Size = new System.Drawing.Size(100, 20);
            this.sphereRadius.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diameter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surface Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Volume";
            // 
            // DiameterOutput
            // 
            this.DiameterOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiameterOutput.Location = new System.Drawing.Point(85, 225);
            this.DiameterOutput.Name = "DiameterOutput";
            this.DiameterOutput.Size = new System.Drawing.Size(100, 23);
            this.DiameterOutput.TabIndex = 5;
            // 
            // SurfaceAreaOutput
            // 
            this.SurfaceAreaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurfaceAreaOutput.Location = new System.Drawing.Point(85, 263);
            this.SurfaceAreaOutput.Name = "SurfaceAreaOutput";
            this.SurfaceAreaOutput.Size = new System.Drawing.Size(100, 23);
            this.SurfaceAreaOutput.TabIndex = 6;
            // 
            // VolumeOutput
            // 
            this.VolumeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VolumeOutput.Location = new System.Drawing.Point(85, 301);
            this.VolumeOutput.Name = "VolumeOutput";
            this.VolumeOutput.Size = new System.Drawing.Size(100, 23);
            this.VolumeOutput.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_3.Properties.Resources.Sphere_and_Ball;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab_3.Properties.Resources.Sphere_and_Ball;
            this.pictureBox2.Location = new System.Drawing.Point(222, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VolumeOutput);
            this.Controls.Add(this.SurfaceAreaOutput);
            this.Controls.Add(this.DiameterOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sphereRadius);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sphereRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DiameterOutput;
        private System.Windows.Forms.Label SurfaceAreaOutput;
        private System.Windows.Forms.Label VolumeOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

