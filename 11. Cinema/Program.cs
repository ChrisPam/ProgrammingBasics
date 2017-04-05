using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var typePremiere = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (typePremiere == "premiere")
            {
                Console.WriteLine("{0:F2} leva", r * c * 12.00);
            }
            else if (typePremiere == "normal")
            {
                Console.WriteLine("{0:F2} leva", r * c * 7.50);
            }
            else if (typePremiere == "discount")
            {
                Console.WriteLine("{0:F2} leva", r * c * 5.00);
            }
        }
    }
}
