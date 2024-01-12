using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryA
{
    internal class Program
    {
        class LibraryBook
        {
            public string title { get; private set; }
            public string author { get; private set; }
            public string ISBN { get; private set; }

            public bool isavaliable { get; private set; }
            public LibraryBook(string title, string author, string isbn)
            {
                this.author = author;
                this.title = title;
                this.ISBN = isbn;
                isavaliable = true;

            }

            public void borrowing()
            {
                if(isavaliable)
                {
                    isavaliable = false;
                    Console.WriteLine("book : " + title + " has been borrowed.");
                }
                else
                {
                    Console.WriteLine("book : " + title + " is not avaliable.");
                }

            }
            public void Return()
            {
                if (!isavaliable)
                {
                    isavaliable = true;
                    Console.WriteLine("Book: " + title + "has been returned.");
                }
                else
                {
                    Console.WriteLine("Book: " + title + " is already available.");
                }
            }
            public void DisplayBookInfo()
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: "  + author);
                Console.WriteLine("ISBN:  " + ISBN);
                Console.WriteLine("Avaliabilty: " + isavaliable );
            }


        }
        static void Main(string[] args)
        {
            // Create a LibraryBook object
            LibraryBook book1 = new LibraryBook("The Lord of the Rings", "J.R.R. Tolkien", "9780547928227");
            LibraryBook book2 = new LibraryBook("The AI", "Bashir gezey", "9780542328227");


            // Display initial book information
            book2.DisplayBookInfo();

            // Borrow the book
            book2.borrowing();

            // Display book information after borrowing
            book2.DisplayBookInfo();
            // Return the book
            book2.Return();

            // Display book information after returning
            book1.DisplayBookInfo();

            // Display initial book information
            book1.DisplayBookInfo();

            // Borrow the book
            book1.borrowing();

            // Display book information after borrowing
            book1.DisplayBookInfo();

            // Return the book
            book1.Return();

            // Display book information after returning
            book1.DisplayBookInfo();

            Console.ReadLine();
        }
    }
}
