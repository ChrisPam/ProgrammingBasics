using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
            
                if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
