﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime dateafter = date.AddDays(999);
            Console.WriteLine(dateafter.ToString("dd-MM-yyyy"));
        }
    }
}
