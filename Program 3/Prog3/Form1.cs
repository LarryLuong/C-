//Grading ID: S5033
//Program Number: 3
//Due Date: 11/11/2021
//Course Section: CIS 199-50
//This program is a Graphical User Interface that can take the input of a location, entree number, and servings to calculate and output the cost, adjusted cost, shipment cost, and total cost.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cityCB.Items.Add("Louisville");
            cityCB.Items.Add("Lexington");
            cityCB.Items.Add("Indianapolis");
            cityCB.Items.Add("Nashville");
            // adds combobox items for selection

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int minItemNum = 10001;
            const int maxItemNum = 10007;
            // const int variables for max and min entree numbers

            string[] cities = { "Louisville", "Lexington", "Indianapolis", "Nashville" };
            double[] shipmentFee = { 0.06, 0.0717, 0.0700, 0.0874 };
            // first set arrays. The cities and their respective shipment fees.

            int[] entreeNumber = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };
            double[] entreeCost = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };
            // second set of arrays. the entree numbers and their respective costs

            int[] servingsLowLimits = { 0, 6, 11, 21 };
            double[] serviceFee = { 0.15, 0.10, 0.05, 0.00 };
            // third set of arrays. the lower limits of the serving sizes and their respective fees

            bool itemFound = false, cityFound = false, quantityFound = false, entreeFound = false, servingFound = false;
            double shipFee = 0, CPS = 0, servFee = 0;
            double initialCost = 0, adjustedCost = 0, shipmentCost = 0, totalPrice = 0;
            int entree = 0, quantity = -1;
            string city = "0";
            // declaring bool variables for validating inputs
            // declaring shipfee, CPS, and servfee for calculations. these variables will be set equal to the selected array amounts
            // declaring variabls for the outputeted prices.
            // delcaring entree, quantity, and city variables to set equal to user inputted values

            if (int.TryParse(entreeInput.Text, out entree) && entree <= maxItemNum && entree >= minItemNum )
                // a try parse statement that parses user input entree item and limited the selection to between the max and min item numbers.
            {
                itemFound = true;
                // if they fit those conditions, itemFound becomes true. later used for validations
            }
            if (int.TryParse(quantityInput.Text, out quantity) && quantity > 0)
                // a try parse statement that parses user input quantity and limits the selection to positive numbers only.
            {
                quantityFound = true;
                // if they fit those conditions, quantityfound becomes true. later used for validation
            }
            if (cityCB.SelectedIndex >= 0)
                // if statement that checks for a combobox selection.
            {
                city = cityCB.Text;
                // string city is then overwritten with a string containing the selected combobox location name
            }

            for (int i = 0; i < cities.Length && !cityFound; i++)
                // for statement that loops until the variables are found in the array. 
            {
                if (city == cities[i])
                    // if statement that checks if the input is equal to an array index
                {
                    shipFee = shipmentFee[i];
                    cityFound = true;
                    // if it does, the cities respective shipment fee variable is set and the cityfound variable becomes true to stop the array from scanning the rest of the array
                }
            }

            for (int j = 0; j < entreeNumber.Length && !entreeFound; j++)
                // for statement that loops until the variables are found in the array.
            {
                if (entree == entreeNumber[j])
                    // if statement that checks if the input is equal to an array index
                {
                    CPS = entreeCost[j];
                    entreeFound = true;
                    // if it does, cost per serving is set equal to its respective entree cost, and entree found is set true for efficiency reasons and validation
                }
            }

            int k = servingsLowLimits.Length - 1;
            //setting up a while loop for serving lower limits. 

            while (k >=0 && !servingFound)
                // while loop that loops until the variables are found in the array.
            {
                if (quantity >= servingsLowLimits[k])
                    servingFound = true;
                // if statement that determines the limit the input falls under. servingfound set to true to break while loop and for validation
                else
                    --k;
                // if the lower limit isnt found, k decreases until it does.
            }
            
            if (servingFound)
                // if statement to set the service fee equal to the array value
            {
                servFee = serviceFee[k];
                // setting variable equal to array value
            }

            if (!itemFound || !quantityFound || !cityFound || !servingFound || !entreeFound)
                // big if statement that validates everything falls under conditions
            {
                if (!itemFound)
                {
                    MessageBox.Show("Error, Invalid Entree Entry", "Status");
                }
                if (!quantityFound)
                {
                    MessageBox.Show("Error, Invalid Quantity Amount", "Status");
                }
                if (!cityFound)
                {
                    MessageBox.Show("Error, Invalid City", "Status");
                }
                return;
                // if anything had an invalid response or an error, a corresponding messagebox will print out
            }

            initialCost = CPS * quantity;
            adjustedCost = initialCost + (initialCost * servFee);
            shipmentCost = adjustedCost * shipFee;
            totalPrice = adjustedCost + shipmentCost;
            // calculations for each cost output

            initialCostOutput.Text = $"{initialCost:C}";
            adjustedCostOutput.Text = $"{adjustedCost:C}";
            shipmentCostOutput.Text = $"{shipmentCost:C}";
            totalPriceOutput.Text = $"{totalPrice:C}";
            // outputting the calculations to each label for display
        }
    }
}
