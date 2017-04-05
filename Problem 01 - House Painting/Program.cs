using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var backSide = Math.Pow(x, 2);
            var frontSide = Math.Pow(x, 2) - (1.2 * 2);

            var leftSide = (x * y) - Math.Pow(1.5, 2);
            var rightSide = (x * y) - Math.Pow(1.5, 2);

            var plosht = backSide + frontSide + leftSide + rightSide;

            var redPaint = plosht / 3.4;

            var pokriv = 2 * (x * y) + 2 * ((h * x) / 2);
            var greenPaint = pokriv / 4.3;
            Console.WriteLine("{0:F2}", redPaint);
            Console.WriteLine("{0:F2}", greenPaint);

        }
    }
}
