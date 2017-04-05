using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var control = int.Parse(Console.ReadLine());

            var sum = 0;
            var count = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum += (i * 2) + (j * 3);
                    count++;
                    if (sum >= control)
                    {
                        Console.WriteLine($"{count} moves");
                        Console.WriteLine($"Score: {sum} >= {control}");
                        return;
                    }
                }
            }
            if(sum < control)
            {
                Console.WriteLine($"{count} moves");
            }
        }
    }
}
