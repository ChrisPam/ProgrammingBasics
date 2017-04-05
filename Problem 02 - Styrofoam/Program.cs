using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02___Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            int windowsCount = int.Parse(Console.ReadLine());
            double sterioporMetersInOnePacket = double.Parse(Console.ReadLine());
            double sterioporPriceForOnePacket = double.Parse(Console.ReadLine());

            double areaForSteriopor = houseArea - (windowsCount * 2.4);
            double areaForFira = (areaForSteriopor * 0.1);

            double totalArea = areaForSteriopor + areaForFira;

            double neededPackets = Math.Ceiling(totalArea / sterioporMetersInOnePacket);

            double priceForSteriopor = neededPackets * sterioporPriceForOnePacket;

            if(budget > priceForSteriopor)
            {
                Console.WriteLine($"Spent: {priceForSteriopor:f2}");
                Console.WriteLine("Left: {0:f2}", budget - priceForSteriopor);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", priceForSteriopor - budget);
            }


        }
    }
}
