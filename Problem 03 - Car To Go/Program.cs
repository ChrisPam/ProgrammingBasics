using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            string carClass;
            string carType;
            double price;
            if (budget <= 100)
            {
                carClass = "Economy";
                Console.WriteLine($"{carClass} class");
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.35;
                    Console.WriteLine("{0} - {1:F2}", carType, price);
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget * 0.65;
                    Console.WriteLine("{0} - {1:F2}", carType, price);
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact";
                Console.WriteLine($"{carClass} class");
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.45;
                    Console.WriteLine("{0} - {1:F2}", carType, price);
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget * 0.80;
                    Console.WriteLine("{0} - {1:F2}", carType, price);
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury";
                Console.WriteLine($"{carClass} class");
                if (season == "Summer" || season == "Winter")
                {
                    carType = "Jeep";
                    price = budget * 0.90;
                    Console.WriteLine("{0} - {1:F2}", carType, price);
                }
            }
        }
    }
}
