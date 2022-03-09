//Grading ID: S5033
//Lab Number: 2
//Due Date: 09/19/2021
//Course Section: CIS 199-50
//This program is a Graphical User Interface that takes a user inputed price and calculates three different tip rates

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            //clicking the button triggers the compiling and reading of the following code
        {
            double num1;
            //declaring variable for user input amount
            
            const double tip1 = .15;
            const double tip2 = .18;
            const double tip3 = .20;
            //setting up variables. one for 0.15, one for 0.18, and the last for 0.20

            double tip1amount;
            double tip2amount;
            double tip3amount;
            //declaring variables for each set tip amount

            num1 = double.Parse(firstNumTxt.Text);
            //reads user input values and sets the variable to that amount

            tip1amount = (num1 * tip1);
            tip2amount = (num1 * tip2);
            tip3amount = (num1 * tip3);
            //calculates tip amounts for each variable

            tip1output.Text = $"{tip1amount:F2}";
            tip2output.Text = $"{tip2amount:F2}";
            tip3output.Text = $"{tip3amount:F2}";
            //outputs the tip amounts into the text box, prints amount out with 2 decimal places
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void firstNumTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
