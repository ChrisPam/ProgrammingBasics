using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //dog - mammal
            //crocodile, tortoise, snake - reptile
            //others - unknown

            var animal = Console.ReadLine().ToLower();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
