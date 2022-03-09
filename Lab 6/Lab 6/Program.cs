//Grading ID: S5033
//Lab number: 6
//Due Date: 10/31/2021
//Course Section: CIS 199-50
// This program will print out 4 different patterns using nested loops instead of multiple writeLine functions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxRows = 10;
            // setting constant integer variable for calculations later

            Console.WriteLine("\nPattern A");
            // prints out the line Pattern A

            for (int row1 = 1; row1 <= maxRows; row1++)
                // for loop that will repeat until row 1 equals the maximum number of rows. Row1 will increase by 1 until it equals that variable
            {
                for (int row2 = 1; row2 <= row1; row2++)
                    // nested loop that print out the number of stars in each pattern
                {
                    Console.Write("*");
                    // prints out the stars for a given row
                }
                Console.WriteLine();
                // prints out the entire line of each row for the pattern
            }
            
            Console.WriteLine("\nPattern B");
            // prints out the line Pattern B

            for (int row1 = maxRows; row1 >= 1; row1--)
                // for loop that will repeat until row 1 equals 1. It runs in reverse from pattern A to set up a different pattern
            {

                for (int row2 = 1; row2 <= row1; row2++)
                // nested loop that prints out the number of stars in the pattern. repeats until row 2 is greater than row 1. row 2 grows by 1 each loop
                {
                    Console.Write("*");
                    // prints out the stars for a given row
                }
                Console.WriteLine();
                // prints out the entire row of stars for the pattern
            }

            Console.WriteLine("\nPattern C");
            // prints out the line Pattern C

            for (int row1 = 1; row1 <= maxRows; row1++)
                // for loop that will set up that basic pattern the nested for loop
            {
                for (int space = row1; space > 1; space--)
                    // nested for loop that will print out the number of spaces needed for a pattern. repeats until space is equal to 1 by minusing 1 each loop.
                {
                    Console.Write(" ");
                    // prints out spaces for a given row
                }

                for (int row2 = maxRows; row2 >= row1; row2--)
                    // 2nd nested for loop that will print out the number of stars needed for a pattern 
                {
                    Console.Write("*");
                    // prints out stars needed for the pattern
                }

                Console.WriteLine();
                // prints out the entire row of spaces and stars 
            }

            Console.WriteLine("\nPattern D");
            // prints out the line Pattern D

            for (int row1 = 1; row1 <= maxRows; row1++)
                // for loop that sets up pattern for the nested loops
            {
                for (int space = maxRows - 1; space >= row1; space--)
                    // nested loop that prints out spaces needed for a given row
                {
                    Console.Write(" ");
                    // prints out the spaces need for the pattern
                }

                for (int row2 = 1; row2 <= row1; row2++)
                    // 2nd nested for loop that prints out stars needed for a given row
                {
                    Console.Write("*");
                    // prints out the stars needed for a given row
                }
                Console.WriteLine();
                // prints out the entire row of spaces and stars
            }
            Console.ReadKey();
            // keeps console application open until user makes an input
        }
    }
}
