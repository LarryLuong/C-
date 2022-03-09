// Grading ID: S5033
// Exam Number: 2
// Due Date: 11/8/2021
// Course Section: CIS 199-50
// This is a simple console application that will let the user enter the name of their state and look up the unemployment rate and the trend in change for that employment rate from the previous year.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exam2_F21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] states = { "Kentucky" , "Alabama", "Florida", "Michigan", "Nevada",

                "New York", "West Virginia", "California", "Wisconsin", "Oregon" };

            double[] unemploymentRates = { 4.3, 3.9, 3.6, 4.1, 4.6,

                4.1, 5.3, 4.2, 3.0, 4.2};

            string[] trend = { "Decrease" , "Decrease", "Decrease", "Decrease", "Decrease",

                "Decrease", "Increase", "Decrease", "Decrease", "Increase"  };

            string input;
            bool valid = false;

            Write("Enter name of state: ");

            input = (ReadLine());
            for (int i = 0; i < states.Length && !valid; i++)
            {
                if (input.ToUpper() == states[i].ToUpper())
                {
                    WriteLine("There is a {0} percent unemployment rate in {1} state. This is a {2} from the previous year.", unemploymentRates[i], input, trend[i]);
                    valid = true;
                }
            }
            if (!valid)
            {
                WriteLine("Sorry, no data for {0} state.", input);
            }
        }
    }
}
