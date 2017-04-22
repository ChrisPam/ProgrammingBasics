using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(' ', n + 1) + "|" + new string(' ', n + 1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', n - i - 1) + new string('*', i + 1) + " | " + new string('*', i + 1) + new string(' ', n - i - 1));

            }
        }
    }
}
