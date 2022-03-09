//Grading ID: S5033
//Program Number: 4
//Due Date: 12/4/2021
//Course Section: CIS 199-50
//This program is a console application with two classes in seperate files. This one will represent books held by a library. It will keep track of books basic information like author, title, publisher...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class LibraryBook
    {
        private int yearOfPublication;
        private bool checkOut;
        private int defaultYear = 2019;
        // Backing fields and a default value

        public LibraryBook(string bookTitle, string bookAuthor, string bookPublisher, int yearOfPublication, string isbn)
        {
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            BookPublisher = bookPublisher;
            YearOfPublication = yearOfPublication;
            ISBN = isbn;
            checkOut = false;
        }
        // Constructor with 5 parameters and checkout status
        // Checkout status will be false by default. All books are in stock in first test.

        public string BookTitle { get; set; }
        // string property for book title. Auto-implemented property
        // Precondition none, Postcondition bookTitle is returned & is set to specified string

        public string BookAuthor { get; set; }
        // string property for book author. Auto-implemented property
        // Precondition none, Postcondition bookAuthor is returned & is set to specified string

        public string BookPublisher { get; set; }
        // string property for book author. Auto-implemented property
        // precondition none, Postcondition bookPublisher is returned & is set to speciifed string

        public int YearOfPublication
        {
            get { return yearOfPublication; }
            // precondition none, postconditioon yearOfPublication is returned

            set
            {
                if (value < 0)
                {
                    yearOfPublication = defaultYear;
                }
                else
                {
                    yearOfPublication = value;
                }
            }
            // validation in the set accessor. If copyright year value is negative, the value is set to default value of 2019. Else the year is set as the speicifed value
        }
        // string property for year of publication.

        public string ISBN { get; set; }
        // string property for isbn. Auto-implemented property
        // preconditon none, postcondition isbn is returned & is set to a specified string

        public void CheckOut()
        {
            checkOut = true;
        }
        // method for checking book out. if checked out the variable will be true. relfects patron has checked out book

        public void ReturnToShelf()
        {
            checkOut = false;
        }
        // method for returning books. if returned to shelf, check out variable will be false. reflects patron has returned book

        public bool isCheckedOut()
        {
            return checkOut;
        }
        // method for returning the books relfecting the check out status of a book

        public override string ToString()
        {
            string objectString = "Title: " + BookTitle + Environment.NewLine + "Author: " + BookAuthor + Environment.NewLine + "Publisher: " + BookPublisher + Environment.NewLine + "Year of Publication: " + YearOfPublication + Environment.NewLine + "ISBN: " + ISBN + Environment.NewLine + "Checked Out: " + isCheckedOut() + Environment.NewLine;
            return objectString;
        }
        // override method for formatting a string for the title, author, etc. Each item has a preceding label and is on a seperate line
        // uses constant Environment.Newline instead of \n

    }
}
