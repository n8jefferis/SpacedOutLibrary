using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacedOutLibrary
{
    public class BookView
    {
        //props
        public Book Displaybook { get; set; }

        //const
        public BookView (Book DisplayBook)
        {
            this.Displaybook = DisplayBook;
        }


        //meth
        


        //public string DateSplit(DateTime )
        //{
        //    string temp = DueDate.ToString();
            
        //    return temp.Substring(0, 3);
        //}
    }
}
