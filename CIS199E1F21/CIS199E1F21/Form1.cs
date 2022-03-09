//Grading ID: S5033
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS199E1F21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pollenCount;
            string category;

            if (double.TryParse(pollenCountInput.Text, out pollenCount) == pollenCount < 0 || pollenCount > 12.0 || false)
            {
                MessageBox.Show("Invalid Pollen Count, Try Again", "Status");
                return;
            }

            if (pollenCount >= 0.0 && pollenCount <= 2.4)
            {
                category = "Low";
                Result.Text = category.ToString();
            }
            
            if (pollenCount >= 2.5 && pollenCount <= 4.8)
            {
                category = "Low-Medium";
                Result.Text = category.ToString();
            }

            if (pollenCount >= 4.9 && pollenCount <= 7.2)
            {
                category = "Medium";
                Result.Text = category.ToString();
            }

            if (pollenCount >= 7.3 && pollenCount <= 9.6)
            {
                category = "High-Medium";
                Result.Text = category.ToString();
            }
            
            if (pollenCount >= 9.7 && pollenCount <= 12.0)
            {
                category = "High";
                Result.Text = category.ToString();
            }

        }
    }
}
