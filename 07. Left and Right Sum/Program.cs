using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum1 = 0;
            var sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum1 += num;
            }
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum2 += num;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sum1 - sum2));
            }
        }
    }
}
