using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01___Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var kgFromM = double.Parse(Console.ReadLine());
            var rejection = double.Parse(Console.ReadLine());

            var grapes = area * kgFromM;
            var totalGrapes = grapes - rejection;

            var forRakia = totalGrapes * 0.45;
            var forSell = totalGrapes * 0.55;

            var RakiaInLiters = forRakia / 7.5;

            var moneyFromRakia = RakiaInLiters * 9.80;
            var moneyFromSell = forSell * 1.50;

            Console.WriteLine($"{moneyFromRakia:f2}");
            Console.WriteLine($"{moneyFromSell:f2}");
        }
    }
}
