using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var dist = int.Parse(Console.ReadLine());
            var part = Console.ReadLine();
            double tips = 0;

            if (dist < 20 && part == "day")
            {
                tips = 0.70 + dist * 0.79;
            }
            else if (dist < 20 && part == "night")
            {
                tips = 0.70 + dist * 0.9;
            }
            else if (dist >= 20 && 100 > dist)
            {
                tips = dist * 0.09;
            }
            else if (dist >= 100)
            {
                tips = dist * 0.06;
            }
            Console.WriteLine(tips);

            Console.ReadLine();
        }
    }
}