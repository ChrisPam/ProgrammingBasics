using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var dotSize = (size * 12) / 2 - 3;
            var hashSize = 1;
            for (int i = 0; i < size * 2; i++)
            {
                Console.Write(new string('.', dotSize));
                Console.Write(new string('#', hashSize));
                Console.Write(new string('.', dotSize));
                Console.WriteLine();

                dotSize -= 3;
                hashSize += 6;
            }

            dotSize = 3;
            hashSize -= 12;
            for (int i = 0; i < size - 2; i++)
            {
                Console.Write('|');
                Console.Write(new string('.', dotSize - 1));
                Console.Write(new string('#', hashSize));
                Console.Write(new string('.', dotSize));
                Console.WriteLine();

                hashSize -= 6;
                dotSize += 3;

            }

            for (int i = 0; i < size; i++)
            {
                if (i == size - 1)
                {
                    Console.Write('@');
                    Console.Write(new string('.', dotSize - 1));
                    Console.Write(new string('#', hashSize));
                    Console.Write(new string('.', dotSize));
                    Console.WriteLine();
                    break;
                }

                Console.Write('|');
                Console.Write(new string('.', dotSize - 1));
                Console.Write(new string('#', hashSize));
                Console.Write(new string('.', dotSize));
                Console.WriteLine();
            }
        }
    }
}