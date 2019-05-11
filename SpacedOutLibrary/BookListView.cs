using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacedOutLibrary
{
    public class BookListView
    {
        //prop
        public List<Book> DisplayBooks { get; set; }
        public List<Book> Results { get; set; }

        //const
        public BookListView(List<Book> DisplayBooks)
        {
            this.DisplayBooks = DisplayBooks;
        }

        public Controller c = new Controller();

        //meth
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Spaced Out Library");
            Console.WriteLine();
            Console.WriteLine("We offer a unique selection of sci-fi literature");
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine(" 1) List all Books");
            Console.WriteLine(" 2) Search by Title");
            Console.WriteLine(" 3) Search by Author");

            bool run = true;
            while (run)
            {
                Console.Write("Please choose 1, 2 or 3: ");
                string input = Console.ReadLine();

                if (input == "1" || input.ToLower() == "list")
                {
                    ListBooks();
                }
                else if (input == "2" || input.ToLower() == "title")
                {
                    List<Book> lb = c.SearchTitle();
                    View(lb);
                }
                else if (input == "3" || input.ToLower() == "author")
                {
                    List<Book> lb = c.SearchAuthor();
                    View(lb);
                }


            }
        }


        public void ListBooks()
        {
            Console.Clear();
            Console.WriteLine(" # TITLE:                    AUTHOR:             DUE DATE:");
            for (int i = 0; i < DisplayBooks.Count; i++)
            {
                Console.WriteLine($"{i + 1,2} {DisplayBooks[i].Title,-25} {DisplayBooks[i].Author,-19} {(DisplayBooks[i].Status == false ? "Available" : DisplayBooks[i].DueDate.ToString())}");
            }

        }

        public void View(List<Book> Results)
        {
            if (Results.Count == 0)
            {
                Console.WriteLine("Your didn't yeild any results, idiot!");
            }
            else
            {
                Console.WriteLine(" # TITLE:                    AUTHOR:             DUE DATE:");
                for (int i = 0; i < Results.Count; i++)
                {
                    Console.WriteLine($"{i + 1,2} {Results[i].Title,-25} {Results[i].Author,-19} {(Results[i].Status == false ? "Available" : Results[i].DueDate)}");
                }
            }
        }




    }
}
