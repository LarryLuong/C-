//Grading ID: S5033
//Program Number: 2
//Due Date: 10/21/21
//Course Section: CIS 199-50
//This program is a Graphical User Interface that can calculate the cost of a trip from the number of passengers, distance, and type of car inputted. The program will calculate each cost and also output the cheapest company for the trip. If the inputted information is invalid, an error messagebox will show 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Car Type Combobox options
            CarTypeCB.Items.Add("Limo"); // index 0
            CarTypeCB.Items.Add("Luxury"); // index 1
            CarTypeCB.Items.Add("Mid-Tier"); // index 2
            CarTypeCB.Items.Add("Green"); // index 3
            CarTypeCB.Items.Add("Economy"); // index 4
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int passenger, passengerB = 0;
            const double distanceFeeA = 0.02, distanceFeeB = .10, passengerC = .25; 
            double distance, distanceFeeC;
            double totalA = 0, totalB = 0, totalC = 0;
            int carType = -1; 
            const int carTypeA0 = 50, carTypeA1 = 40, carTypeA2 = 25, carTypeA3 = 15, carTypeA4 = 7, passengerA = 2, carTypeC = 20;
            bool validDist = false, validPass = false;
            string lowestCost = "0";
            // declaring variables. The variables equal to certain numbers eliminates "magic numbers".
            // declaring string for lowest cost message
            // declaring bool for input validation

            // Valid input check
            if (double.TryParse(DistInput.Text, out distance))
                // if statement to Parse for distance input, outputs it as distance variable. if successfully parsed
            {
                validDist = true;
                // distance validation set to true
            }
            if (int.TryParse(passInput.Text, out passenger))
                // if statement to parse for passenger input, outputs it as passenger variable, if successfully parsed
            {
                validPass = true;
                // passenger validation set to true
            }
            if (CarTypeCB.SelectedIndex >= 0)
                // if statment for combobox
            {
                carType = CarTypeCB.SelectedIndex;
                // sets car type variable equal to combobox index
            }

            // Valid inputs test
            if (!validDist)
                // validation for distance input
            {
                MessageBox.Show("Invalid Distance", "status 1");
                // messagebox for invalid distance, status for looks & easier debug
            }
            else if (distance < 0)
                // validation for within distance criteria
            {
                MessageBox.Show("Invalid Distance", "status 2");
                // messagebox for invalid distance, status for looks & easier debug
            }

            if (!validPass)
                // validation for passenger input
            {
                MessageBox.Show("Invalid passengers", "status 1");
                // messagebox for invalid passenger, status for looks & easier debug
            }
            else if (passenger < 1 || passenger > 12)
                // validation for within passenger criteria
            {
                MessageBox.Show("Invalid passengers", "status 2");
                // messagebox for invalid passengers, status for looks & easier debug
            }
            
            if (carType < 0 || carType > 4)
                // validation for car type input. default car type value is -1, if no option is selected
            {
                MessageBox.Show("Please select a Car Type", "status");
                // messagebox for invalid car type appears
            }


            // Company A calculations
            if (carType == 0)
                // if statement for company A calculations with car type Limo
            {
                totalA = (passenger * passengerA) + (distance * distanceFeeA) + (carTypeA0);
                // company A total calculation w/ limo type
            }
            else if (carType == 1)
                // if statement for company A calculations with car type Luxury
            {
                totalA = (passenger * passengerA) + (distance * distanceFeeA) + (carTypeA1);
                // company A total calculation w/ luxury type
            }
            else if (carType == 2)
                // if statement for company A calculations with car type Mid-Tier
            {
                totalA = (passenger * passengerA) + (distance * distanceFeeA) + (carTypeA2);
                // company A total calculation w/ mid-tier type
            }
            else if (carType == 3)
                //  if statement for company A calculations with car type Green
            {
                totalA = (passenger * passengerA) + (distance * distanceFeeA) + (carTypeA3);
                // company A total calculation w/ green type
            }
            else
            // else statement for leftover car type Economy
            {
                totalA = (passenger * passengerA) + (distance * distanceFeeA) + (carTypeA4);
                // company A total calculation w/ economy type
            }

            // Company B calculations
            if (passenger <= 2)
                // if statement for setting passengerb variable to corresponding price
            {
                passengerB = 20;
                // passenger b variable set to $20 per person
            }
            else if (passenger <= 6)
                // if statement for setting passengerb variable to corresponding price
            {
                passengerB = 15;
                // passenger b variable set to $15 per person
            }
            else if (passenger <= 12)
                // if statement for setting passengerb variable to corresponding price
            {
                passengerB = 5;
                // passenger b variable set to $5 per person
            }

            if (carType == 0 || carType == 1)
                // if statement for certain car type input
            {
                totalB = (passenger * passengerB) + (distance * distanceFeeB) + (carTypeA1);
                // if within those parameters, company B uses this formula for calculation
            }
            else if (carType == 2)
                // if statement for certain car type input
            {
                totalB = (passenger * passengerB) + (distance * distanceFeeB) + (carTypeA2);
                // if within those parameters, company B uses this formula for calculation
            }
            else if (carType == 3 || carType == 4)
                // if statement for certain car type input
            {
                totalB = (passenger * passengerB) + (distance * distanceFeeB) + (carTypeA3);
                // if within those parameters, company B uses this formula for calculation
            }

            // Company C calculations
            if (distance <= 9)
                // if statement for setting distance fee variable to corresponding price
            {
                distanceFeeC = 5;
                // distanceFeeC variable set to $5
            }
            else if (distance <= 49)
                // if statement for setting distance fee variable to corresponding price
            {
                distanceFeeC = 15;
                // distanceFeeC variable set to $15
            }
            else if (distance <= 99)
                // if statement for setting distance fee variable to corresponding price
            {
                distanceFeeC = 25;
                // distanceFeeC variable set to $25
            }
            else if (distance <= 199)
                // if statement for setting distance fee variable to corresponding price
            {
                distanceFeeC = 35;
                // distanceFeeC variable set to $35
            }
            else
                // else statement for setting distance fee variable to corresponding price
            {
                distanceFeeC = 40;
                // distanceFeeC variable set to $40
            }

            totalC = (passenger * passengerC) + (distanceFeeC) + (carTypeC);
            // company C total formula calculation

            if (totalA < totalB && totalA < totalC)
                // if statement for if company A is the lowest cost
            {
                lowestCost = "A";
                // sets lowest cost as company A
            }
            else if (totalB < totalA && totalB < totalC)
            // if statement for if company B is the lowest cost
            {
                lowestCost = "B";
                // sets lowest cost as company B
            }
            else if (totalC < totalA && totalC < totalB)
            // if statement for if company C is the lowest cost
            {
                lowestCost = "C";
                // sets lowest cost as company C
            }

            if (!validDist && !validPass || carType == -1)
                // if statement for validation test if both passengers and distance input are left blank or are invalid / if car type if left blank
            {
                totalA = 0;
                totalB = 0;
                totalC = 0;
                lowestCost = "N/A";
                MessageBox.Show("Error, Invalid Input", "Status");
                // if both validation tests fail or car type is left empty, it displays 0 only and displays error message box and sets lowest company as N/A
                // doing this so the program wont display incorrect values for an invalid entry
            }
            if (distance < 1 || passenger > 12 || passenger < 1 || carType == -1)
            {
                totalA = 0;
                totalB = 0;
                totalC = 0;
                lowestCost = "N/A";
                MessageBox.Show("Error, Invalid Input", "Status");
                // if one validation tests fail or car type is left empty, it displays 0 only and displays error message box and sets lowest company as N/A
                // doing this so the program wont display incorrect values for an invalid entry
            }

            // Company Outputs
            companyAOutput.Text = $"{totalA:C}";
            companyBOutput.Text = $"{totalB:C}";
            CompanyCOutput.Text = $"{totalC:C}";
            // outputs totals in the label boxes in currency form

            lowestCostOutput.Text = String.Format("The lowest cost company is: {0}", lowestCost);
            // outputs the company with the lowest price in the label box
        }
    }
}
