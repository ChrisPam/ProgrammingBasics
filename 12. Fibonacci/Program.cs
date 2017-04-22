using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                var f0 = 1;
                var f1 = 1;

                for (int i = 1; i < n; i++)
                {
                    var fNext = f0 + f1;
                    f0 = f1;
                    f1 = fNext;
                }
                Console.WriteLine(f1);
            }
            
        }
    }
}
