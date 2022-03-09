//Grading ID: S5033
//Program Number: 1
//Due Date: 9/30/2021
//Course Section: CIS 199-50
//This program is a Graphical User Interface that can calculate the given price of building a pool with several inputs from the user. The Program can be configured to print calculations with or without excavation costs and diving board installations.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        //clicking the calculate button triggers the compiling and reading of the following code
        {
            double PoolWidth, PoolLength, PoolDepth, MatPrice, CubicYards, MatCost, ExcavCost, BoardAmount, LaborCost, TotalCost, ExcessAmount;
            //Delcaring variables for the calculation of Cubic Yards, Material Costs, Labor Costs, ETC...
            int Excavation, DivingBoard;
            //Declaring Excavation and DivingBoard variables as integers for their input later
            const double Excess = .10;
            //Declaring Excess as 10% for a calculation later

            const double ExcavRate = 15;
            const double LaborRate = 3.25;
            //Declaring variables as rates for calculation

            PoolWidth = double.Parse(WidthInput.Text);
            PoolLength = double.Parse(LengthInput.Text);
            PoolDepth = double.Parse(DepthInput.Text);
            MatPrice = double.Parse(MatPriceInput.Text);
            //Reads user input for each textbox and sets variables equal to it

            CubicYards = (PoolWidth * PoolLength * PoolDepth) / 27;
            //Calculates cubic yards using the variables of the pool dimensions
            MatCost = (CubicYards * MatPrice);
            //Calculates material costs using the calculated cubic yards and the variable for material price
            ExcessAmount = (MatCost * Excess);
            //Calculation for how much the excess 10% would be for material costs
            MatCost += ExcessAmount;
            //Equation that adds the excess 10% to the total material costs

            Excavation = int.Parse(ExcavInput.Text);
            //Reads the user input for the given textbox and sets variable equal to it
            if (Excavation == 1)
            {
                ExcavCost = CubicYards * ExcavRate;
            }
            else
            {
                ExcavCost = 0;
            }
            //If the variable is equal to the number 1, it calculates excavation cost, anything else will return excavation cost with a value of $0

            DivingBoard = int.Parse(BoardInput.Text);
            //Reads the user input for the given textbox and sets variable equal to it
            if (DivingBoard ==1)
            {
                BoardAmount = 50.00;
            }
            else
            {
                BoardAmount = 0;
            }
            //If the variable is equal to the number 1, it sets the board amount variable equal to $50, anything else will set the board amount variable equal to $0

            LaborCost = (CubicYards * LaborRate + BoardAmount);
            //Calculates labor cost with cubic yard variable, the labor rate, and adds the board amount variable

            TotalCost = (MatCost + ExcavCost + LaborCost);
            //Calculates total costs with the material cost variable, excavation cost variable, and labor cost variable

            YardsOutput.Text = String.Format("{0:F1}", CubicYards);
            MatCostOutput.Text = $"{MatCost:C}";
            ExcavCostOutput.Text = $"{ExcavCost:C}";
            LaborCostOutput.Text = $"{LaborCost:C}";
            TotalCostOutput.Text = $"{TotalCost:C}";
            //Formats values as a string or as currency and prints them out into the label text box
        }
    }
}
