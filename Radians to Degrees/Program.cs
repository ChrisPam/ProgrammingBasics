using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var degree = double.Parse(Console.ReadLine());

            var radian = degree * 57.29578;

            Console.WriteLine(Math.Round(radian));
        }
    }
}
