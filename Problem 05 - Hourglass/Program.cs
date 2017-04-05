using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', 2 * n + 1));
            Console.WriteLine(".*" + new string(' ', (2 * n + 1) - 4) + "*.");
            var dotsLength = 2;
            var maimunkaLeght = (n * 2) - 5;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string('.', dotsLength) + "*" + new string('@', maimunkaLeght) + "*" + new string('.', dotsLength));
                dotsLength++;
                maimunkaLeght = maimunkaLeght - 2;
            }
            Console.WriteLine(new string('.', n) + "*" + new string('.', n));
            var dots1Lenght = n - 1;
            var maimunka1Lenght = 1;
            Console.WriteLine(new string('.', dots1Lenght) + "*" + new string('@', maimunka1Lenght) + "*" + new string('.', dots1Lenght));
            dots1Lenght--;
            var spaceLenght = 1;
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine(new string('.', dots1Lenght) + "*" + new string(' ', spaceLenght) + "@" + new string(' ', spaceLenght) + "*" + new string('.', dots1Lenght));
                dots1Lenght--;
                spaceLenght++;
            }
            Console.WriteLine(".*" + new string('@', n * 2 - 3) + "*.");
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}
