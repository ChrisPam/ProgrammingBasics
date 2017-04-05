using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01___Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());

            var leftAndRightSide = A * (A / 2) * 2;
            var backSide = Math.Pow(A / 2, 2) + ((A / 2) * (B - A / 2)) / 2;
            var door = Math.Pow(A / 5, 2);
            var frontSide = backSide - door;
            var bothSideSum = leftAndRightSide + backSide + frontSide;

            var greenPaint = bothSideSum / 3;

            var roof = (A * (A / 2)) * 2;
            var redPaint = roof / 5;

            Console.WriteLine("{0:F2}", greenPaint);
            Console.WriteLine("{0:F2}", redPaint);
        }
    }
}
