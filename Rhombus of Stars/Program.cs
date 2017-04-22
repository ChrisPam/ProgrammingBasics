using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i) + "* ");
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            // n = 3
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string(' ', i) + "* ");
                for (int j = n - 2; j > i - 1; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
