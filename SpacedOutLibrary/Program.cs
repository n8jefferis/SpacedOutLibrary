using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacedOutLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<string> book = new List<string>() {"Farenheit 451", "Ray Radbury", "Dune",
                "Frank Herbert", "The Callista Chronicles", "Callista Gloss", "Frankenstein", "Mary Shelly",
            "A Wrinkle in Time", "Madeleine L'Engle", "2001", "Arthur C. Clarke",
                "The Hitchhiker's Guide to the Galaxy", "Douglas Adams", "Star Wars", "George Lucas",
            "I,Robot","Issac Asimov", "Jurassic Park", "Michael Crichton", "1984", "George Orwell", "Avengers End Game", "Stan Lee",
            };

            List<Book> Books = new List<Book>();

            for(int i = 0; i < book.Count; i+=2)
            {
                Book b = new Book();

                b.Title = book[i];
          
                b.Author = book[i+1];
             
                b.Status = false;
                b.DueDate = "";

                Books.Add(b);
                
            }



            BookListView blv = new BookListView(Books);

            blv.Display();










        }
    }
}
