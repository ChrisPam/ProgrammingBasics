﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            {
                Console.WriteLine($"{(budget - totalSum):f2} lv left.");
            }
            {
                Console.WriteLine($"You'll need {(totalSum - budget):f2} lv more.");
            }
        }
    }
}