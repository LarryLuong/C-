//Grading ID: S5033
//Lab Number: 3
//Due Date: 09/26/2021
//Course Section: CIS 199-50
//This program is a Graphical User Interface that takes a user inputed radius of a sphere and calculates diameter, surface area, and volume.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            //clicking the calculate button triggers the compiling and reading of the following code
        {
            double Radius, Diameter, SurfaceArea, Volume;
            //declares variables for Radius, Diameter, SurfaceArea, and Volume
           
            Radius = double.Parse(sphereRadius.Text);
            //reads user input value and sets the variable to that amount

            Diameter = Radius * 2;
            SurfaceArea = 4 * Math.PI * Math.Pow(Radius, 2);
            Volume = (4 * Math.PI * Math.Pow(Radius,3)) / 3;
            //calculates the values for each variable with their respective formulas

            DiameterOutput.Text = String.Format("{0:F2}", Diameter);
            SurfaceAreaOutput.Text = String.Format("{0:F2}",SurfaceArea);
            VolumeOutput.Text = String.Format("{0:F2}",Volume);
            //Formats value as a string and prints the output into a text box
        }
    }
}