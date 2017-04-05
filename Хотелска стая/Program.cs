using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskaStaq
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());

            if (month == "may" || month == "october")
            {
                if (nights > 7 && nights < 14)
                {
                    var studioOtstupka = 50 - (50 * 0.05);
                    var apart = 65 * nights;
                    var studio = studioOtstupka * nights;
                    Console.WriteLine("Apartment: {0:F2} lv.\nStudio: {1:F2} lv.", apart, studio);
                }
                else if (nights > 14)
                {
                    var studioOtstupka = 50 - (50 * 0.30);
                    var apartOtstupka = 65 - (65 * 0.10);
                    var apart = apartOtstupka * nights;
                    var studio = studioOtstupka * nights;
                    Console.WriteLine("Apartment: {0:F2} lv.\nStudio: {1:F2} lv.", apart, studio);
                }
                else
                {
                    var studio = 50 * nights;
                    var apart = 65 * nights;
                    Console.WriteLine("Apartment: {0:F2} lv.\nStudio: {1:F2} lv.", apart, studio);
                }
            }
            if (month == "june" || month == "september")
            {
                if (nights > 14)
                {
                    var studioOtstupka = 75.20 - (75.20 * 0.20);
                    var apartOtstupka = 68.70 - (68.70 * 0.10);
                    var apart = apartOtstupka * nights;
                    var studio = studioOtstupka * nights;
                    Console.WriteLine("Apartment: {0:F2} lv.\nStudio: {1:F2} lv.", apart, studio);
                }
                else
                {
                    var studio = 75.20 * nights;
                    var apart = 68.70 * nights;
                    Console.WriteLine("Apartment: {0:F2} lv.\nStudio: {1:F2} lv.", apart, studio);
                }
            }
            if (month == "july" || month == "august")
            {
                var studio = 76 * nights;
                if (nights > 14)
                {
                    var apartOtstupka = 77 - (77 * 0.10);
                    var apart = apartOtstupka * nights;
                    Console.WriteLine("Apartment: {0:F2} lv.\nStudio: {1:F2} lv.", apart, studio);
                }
                else
                {
                    var apart = 77 * nights;
                    Console.WriteLine("Apartment: {0:F2} lv.\nStudio: {1:F2} lv.", apart, studio);
                }
            }
        }
    }
}