//Grading ID: S5033
//Lab number 4
//Due Date: 10/3/2021
//Course Section: CIS 199-50
// This program is a GUI that can make simple admission decisions that can accept or reject them based on a certain specificied Grade Point Average and Test Score. It will also keep track of total accepted and rejected admissions.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TotalAccepted = 0;
            int TotalRejected = 0;
            // Declaring variables as integers set to 0
            // Declared outside of button click event as to not reset the variable's amount

            float GradePointAverage, TestScore;
            // Declaring variables for use in calculations later
            

            if (float.TryParse(GPA.Text, out GradePointAverage) == GradePointAverage < 0 || GradePointAverage > 4 || false)
                // If statement that reads inputs for GPA less than 0, or greater than 4, or invalid. Rewrites the variable as the inputted amount
            {
                MessageBox.Show("Invalid GPA", "Status");
                // If true it prints a message box
                return;
                // Stops the program and returns it to the beginning
            }

            if (float.TryParse(TestScoreInput.Text, out TestScore) == TestScore < 0 || TestScore > 100 || false)
                // If statement that reads input for Test Scores less than 0, or greater than 100, or invalid. Rewrites the variable as the inputted amount
            {
                MessageBox.Show("Invalid Test Score", "Status");
                // If true it prints a message box
                return;
                // Stops the program and returns it to the beginning
            }

            if ((GradePointAverage >= 3.0 && TestScore >= 60) || (GradePointAverage < 3.0 && TestScore >= 80))
            // If statement that reads the variable for the amounts that reach the accepted specifications
            // (GPA greater than 3.0 and test score greater than or equal to 60 or GPA less than 3.0 and test score greater than or equal to 80)
            {
                TotalAccepted ++;
                TotalAcceptedAmount.Text = TotalAccepted.ToString();
                MessageBox.Show("Application Accepted", "Status");
                //Increases the variables amount by 1, prints the amount on the textbox, and prints out a message box
            }

            else
            {
                TotalRejected ++;
                TotalRejectedAmount.Text = TotalRejected.ToString();
                MessageBox.Show("Application Rejected", "Status");
                //Increases the variables amount by 1, prints the amount on the textbox, and prints out a message box
            }
        }

        private void TotalAcceptedAmount_Click(object sender, EventArgs e)
        {

        }

        private void TotalRejectedAmount_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
