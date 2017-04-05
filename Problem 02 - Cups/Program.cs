using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededCups = int.Parse(Console.ReadLine());
            var humans = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());

            var hours = humans * days * 8;
            var izraboteniCups = Math.Floor(hours / 5d);

            if (neededCups > izraboteniCups)
            {
                var ostanali = neededCups - izraboteniCups;
                var zagubi = ostanali * 4.2;
                Console.WriteLine($"Losses: {zagubi:F2}");
            }
            else if (neededCups < izraboteniCups)
            {
                var ostanali = izraboteniCups - neededCups;
                var pechalbi = ostanali * 4.2;
                Console.WriteLine($"{pechalbi:F2} extra money");
            }

        }
    }
}
