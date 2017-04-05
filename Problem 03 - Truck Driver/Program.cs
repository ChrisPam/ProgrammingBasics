using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double kmForMonth = double.Parse(Console.ReadLine());

            double moneyForKm = 0;
            if( season == "spring" || season == "autumn")
            {
                if(kmForMonth <= 5000)
                {
                    moneyForKm = 0.75;
                }
                else if(kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    moneyForKm = 0.95;
                }
                else if(kmForMonth > 10000 && kmForMonth <= 20000)
                {
                    moneyForKm = 1.45;
                }
            }
            else if(season == "summer")
            {
                if (kmForMonth <= 5000)
                {
                    moneyForKm = 0.90;
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    moneyForKm = 1.10;
                }
                else if (kmForMonth > 10000 && kmForMonth <= 20000)
                {
                    moneyForKm = 1.45;
                }
            }
            else if(season == "winter")
            {
                if (kmForMonth <= 5000)
                {
                    moneyForKm = 1.05;
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    moneyForKm = 1.25;
                }
                else if (kmForMonth > 10000 && kmForMonth <= 20000)
                {
                    moneyForKm = 1.45;
                }
            }

            var earnedMoney = (moneyForKm * kmForMonth) * 4;
            var tax = earnedMoney * 0.1;

            var netoMoney = earnedMoney - tax;

            Console.WriteLine($"{netoMoney:f2}");

        }
    }
}
