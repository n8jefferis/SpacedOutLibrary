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
            Book b = new Book();

            b.Title = "Star Wars";
            b.Author = "George Lucas";
            b.Status = false;

            DateTime dat = new DateTime();
            b.DueDate = dat.ToString("01/01/1900");
            Console.Write(b.DueDate);

            List<Book> Books = new List<Book>();
            Books.Add(b);
           

            BookListView blv = new BookListView(Books);

            blv.Display();

            








        }
    }
}
