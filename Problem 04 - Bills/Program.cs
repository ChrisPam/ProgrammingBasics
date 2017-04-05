using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());

            double priceWater = 0;
            double priceElecticity = 0;
            double priceInternet = 0;
            double priceOther = 0;
            double priceOtherTotal = 0;
            double avarage = 0;
            

            priceWater = 20 * months;
            priceInternet = 15 * months;
            for (int i = 1; i <= months; i++)
            {
                var bill = double.Parse(Console.ReadLine());
                priceElecticity += bill;
                priceOther = (bill + 20 + 15) + (0.2 * (bill + 20 + 15));
                priceOtherTotal += priceOther;
            }
            avarage = (priceElecticity + priceWater + priceInternet + priceOtherTotal) / months;
            Console.WriteLine($"Electricity: {priceElecticity:f2} lv");
            Console.WriteLine($"Water: {priceWater:f2} lv");
            Console.WriteLine($"Internet: {priceInternet:f2} lv");
            Console.WriteLine($"Other: {priceOtherTotal:f2} lv");
            Console.WriteLine($"Average: {avarage:f2} lv");
        }
    }
}
