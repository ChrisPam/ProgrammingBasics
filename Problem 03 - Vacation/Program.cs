using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            string location = "";
            string pomeshtenie = "";
            double price = 0;
            if (budget <= 1000)
            {
                pomeshtenie = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                pomeshtenie = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                pomeshtenie = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.90;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.90;
                }
            }
            Console.WriteLine("{0} - {1} - {2:F2}", location, pomeshtenie, price);
        }
    }
}
