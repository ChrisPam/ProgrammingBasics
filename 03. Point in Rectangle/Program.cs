using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            bool first = x == x1 && y >= y1 && y <= y2;
            bool second = x == x2 && y >= y1 && y <= y2;
            bool third = y == y1 && x >= x1 && y <= y2;
            bool fourth = y == y2 && x >= x1 && y <= y2;
            var secondPoint = y2 - y1;

            if(first || second || third || fourth)
            {
                Console.WriteLine("Inside");
            }
            else if (x >= x1 && x <= x2 && y >= y1 && y >= y2) {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Inside");
            }
        }
    }
}
