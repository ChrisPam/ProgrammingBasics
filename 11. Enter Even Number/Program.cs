using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var isFound = true;
            while (isFound)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int number = int.Parse(Console.ReadLine());

                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {number}");
                        isFound = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
