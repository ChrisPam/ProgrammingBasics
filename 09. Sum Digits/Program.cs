using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var sum = 0;
            while (number != 0)
            {
                var lastNumber = number % 10;
                sum += lastNumber;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
