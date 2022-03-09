//Grading ID: S5033
//Lab number: 7
//Due Date: 11/14/2021
//Course Section: CIS 199-50
//Program takes a user input for desired number of stars per side and prints out a pattern.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid; 
            int stars;
            // variable for validiation
            // variable for user input

            do 
                // runs loop at least once
            {
                Write("Enter A Number: "); 
                // writes a statement for user input
                valid = int.TryParse(ReadLine(), out stars) && stars >= 1; 
                // reads userinput and outputs it as the variable stars. Checks if it fits within parameters.
            }
            while (!valid); 
            // loops until conditions are met
            ShowSquareOfStars(stars); 
            // method call for output
        }
    
        public static void ShowSquareOfStars (int numStars) 
            // print method
        {
            for (int i = 1; i <= numStars; i++) 
                // loop until less than/equal to num stars. For rows
            {
                for (int j = 1; j <= numStars; j++) 
                    // loop until less than/equal to num stars. for printing stars
                    Write("*");
                // prints stars
                WriteLine();
                // starts newline for next row
            }
        }
    }
}