//Grading ID: S5033
//Program Number: 4
//Due Date: 12/4/2021
//Course Section: CIS 199-50
//This program is a console application with two classes in seperate files. This one will be the test application where the Main method is located. It will keep track of books basic information like author, title, publisher...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class Program
    {
        public static void OutputLibraryBook(LibraryBook[] book)
        {
            foreach (LibraryBook i in book)
            {
                WriteLine(i.ToString());
            }
        }
        // foreach loop to display each element

        static void Main(string[] args)
        {
            LibraryBook book0 = new LibraryBook("Dune", "Frank Herbert", "---------", 1965, "9780575068568");   // Missing publisher
            LibraryBook book1 = new LibraryBook("Of Mice and Men", "John Steinbeck", "---------", 1937, "9780582461468");   // Missing publisher
            LibraryBook book2 = new LibraryBook("The Lord of the Rings", "J. R. R. Tolkien", "Allen & Unwin", 1954, "---------");   // Missing ISBN
            LibraryBook book3 = new LibraryBook("To Kill a Mockingbird", "Harper Lee", "J. B. Lippincott & Co.", -1960, "9783498038083");   // Negative publication year to test default year
            LibraryBook book4 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald", "Charles Scribner's Sons", 1925, "9780521402309"); // normal class
            // Create 5 LibraryBook objects

            LibraryBook[] book = new LibraryBook[5];
            // create 5 element library book array

            book[0] = book0;
            book[1] = book1;
            book[2] = book2;
            book[3] = book3;
            book[4] = book4;
            // initialize array with books

            OutputLibraryBook(book);
            // method call for displaying the library database
            // prints out all the books' original data

            book0.BookPublisher = "Chilton Books";
            book1.BookPublisher = "Covici Friede";
            book2.ISBN = "9788845292613";
            book3.CheckOut();
            book4.CheckOut();
            // changes books publisher, ISBN or checks the book out

            WriteLine("______________________________________________________________________________________________________________\n");
            WriteLine("______________________________________________________________________________________________________________\n");
            // seperates each database 

            OutputLibraryBook(book);
            // method call for displaying the new library database after data has been changed
            // same method call used earlier

            foreach (LibraryBook i in book)
            {
                i.ReturnToShelf();
            }
            // foreach loop that changes every books' checkout status false. Returns all books to shelf

            WriteLine("______________________________________________________________________________________________________________\n");
            WriteLine("______________________________________________________________________________________________________________\n");
            // seperates the library database outputs

            OutputLibraryBook(book);
            // method call for displaying the new library database after all books have been returned
            // same method call used earlier
        }
    }
}