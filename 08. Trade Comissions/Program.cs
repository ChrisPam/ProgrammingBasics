using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var budget = double.Parse(Console.ReadLine());

            if (city == "sofia")
            {
                if (budget >= 0 && budget <= 500) Console.WriteLine("{0:F2}", budget * 0.05);
                else if (budget > 500 && budget <= 1000) Console.WriteLine("{0:F2}", budget * 0.07);
                else if (budget > 1000 && budget <= 10000) Console.WriteLine("{0:F2}", budget * 0.08);
                else if (budget > 10000) Console.WriteLine("{0:F2}", budget * 0.12);
                else Console.WriteLine("error");
            }
            else if (city == "varna")
            {
                if (budget >= 0 && budget <= 500) Console.WriteLine("{0:F2}", budget * 0.045);
                else if (budget > 500 && budget <= 1000) Console.WriteLine("{0:F2}", budget * 0.075);
                else if (budget > 1000 && budget <= 10000) Console.WriteLine("{0:F2}", budget * 0.1);
                else if (budget > 10000) Console.WriteLine("{0:F2}", budget * 0.13);
                else Console.WriteLine("error");
            }
            else if (city == "plovdiv")
            {
                if (budget >= 0 && budget <= 500) Console.WriteLine("{0:F2}", budget * 0.055);
                else if (budget > 500 && budget <= 1000) Console.WriteLine("{0:F2}", budget * 0.08);
                else if (budget > 1000 && budget <= 10000) Console.WriteLine("{0:F2}", budget * 0.12);
                else if (budget > 10000) Console.WriteLine("{0:F2}", budget * 0.145);
                else Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
