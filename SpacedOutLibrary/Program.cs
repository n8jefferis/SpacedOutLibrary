﻿using System;
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

            Controller c = new Controller();
            c.Run();

            // For STEVE'S Checkout Class
            //DateTime thismoment = DateTime.Today;
            //DateTime twoWeeksFromNow = thismoment.AddDays(14);
            //string date = twoWeeksFromNow.ToString();
            //string date2 = date.Substring(0, date.IndexOf(' '));
            //Console.WriteLine(date2);

        }
    }
}
