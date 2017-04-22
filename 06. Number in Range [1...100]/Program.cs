using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {

            var isFound = true;

            while (isFound)
            {
                Console.Write("Enter a number in the range [1...100]: ");
                int number = int.Parse(Console.ReadLine());

                if (number <= 100 && number >= 1)
                {
                    Console.WriteLine($"The number is: {number}");
                    isFound = false;
                }

                else if (isFound == true)
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            
        }
    }
}
