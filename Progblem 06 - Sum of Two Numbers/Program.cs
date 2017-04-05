using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06___Two_Numbers_Sum

{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var combinationN = 0;
            bool founded = false;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    if (i + j == magicNumber)
                    {
                        combinationN++;
                        Console.WriteLine($"Combination N:{combinationN} ({i} + {j} = {magicNumber})");
                        founded = true;
                        break;
                    }
                    else
                    {
                        combinationN++;
                    }
                }
                if (founded == true)
                {
                    break;
                }
            }

            if (founded == false)
            {
                Console.WriteLine($"{combinationN} combinations - neither equals {magicNumber}");
            }
        }
    }
}