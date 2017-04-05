using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = decimal.Parse(Console.ReadLine());

            var bgn = usd * 1.79549m;

            Console.WriteLine("{0} BGN", Math.Round(bgn, 2));
        }
    }
}
