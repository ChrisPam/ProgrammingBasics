using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = 0.165;
            Console.WriteLine(Math.Round(d, 2));
            Console.WriteLine("{0:F2}", d);
            Console.WriteLine(Math.Ceiling(d));
        }
    }
}
