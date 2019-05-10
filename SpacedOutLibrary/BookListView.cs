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
        
        //const
        public BookListView (List<Book> DisplayBooks)
        {
            this.DisplayBooks = DisplayBooks;
        }

        //meth
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Spaced Out Library");
            Console.WriteLine();
            Console.WriteLine("We offer a unique selection of sci-fi literature");
            Console.WriteLine();
            Console.WriteLine(" # TITLE:                    AUTHOR:             DUE DATE:");
            for(int i = 0; i < DisplayBooks.Count; i++)
            {
                Console.WriteLine($"{i + 1, 2} {DisplayBooks[i].Title,-25} {DisplayBooks[i].Author,-19} {(DisplayBooks[i].Status == false ? "Available" : DisplayBooks[i].DueDate.ToString())}");
            }
        }

    }
}
