//Grading ID: S5033
//Lab number: 5
//Due Date: 10/17/2021
//Course Section: CIS 199-50
// This program can continuously prompt the user for temperature inputs and can calculate the average out of those numbers. It will display the total number of valid input and the mean of the numbers. If something doesnt fit within the criteria, it will print an error message

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double temp, sum = 0;
            bool validTemp = false;
            //Declaring variables. count keeps track of total valid inputs, temp is for user inputs, sum later caluclations.
            //Declaring bool for number verficiation


            WriteLine("Enter temperatures from -20 to 130 Fahrenheit (999 to stop)");
            Write("Enter Temperature: ");
            // prints out message for user to read

            if (double.TryParse(Console.ReadLine(), out temp))
                // scans and parses the input, outputs it as temp variable
            {
                validTemp = true;
                // if statement sets validTemp as true for number verification later
            }

            while (temp != 999)
                // while statement for looping for anything other than 999
            {
                Write("Enter Temperature: ");
                // prints enter temperature for every user input

                if (!validTemp)
                    // if statement for when the input is not a numerically invalid
                {
                    WriteLine("Valid temperature range from -20 to 130 Fahrenheit. Please reenter temperature.");
                    //prints error message

                }
                else if (temp >= -20 && temp <= 130)
                    // else if statement that sets up parameters for valid numbers
                {
                    sum += temp;
                    ++count;
                    // sum variable adds temperature to itself. will be used later for average calculation
                    // count will increase incrementally by 1
                }

                else
                // else statement for anything that doesnt fit the parameters
                {
                    WriteLine("Valid temperature range from -20 to 130 Fahrenheit. Please reenter temperature.");
                    // prints error message
                }

                if (double.TryParse(Console.ReadLine(), out temp))
                 // looping try parse statement for new user inputs
                {
                    validTemp = true;
                    // set as true for number verification
                }
                else
                // else statement if its not true
                {
                    validTemp = false;
                    // set as false for number verification
                }
            }

            WriteLine("You entered {0} valid temperatures.", count);
            WriteLine("The mean temperature is {0} degrees.", sum / count);
            WriteLine("Press any key to continue...");
            Console.ReadKey();
            // prints out the total valid numbers, calculates and displays temperature mean, ReadKey keeps program window open
        }
    }
}