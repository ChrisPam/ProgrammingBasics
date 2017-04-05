using System;
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
            var budget = double.Parse(Console.ReadLine());            var floorHeight = double.Parse(Console.ReadLine());            var floorWidth = double.Parse(Console.ReadLine());            var tileSide = double.Parse(Console.ReadLine());            var tileHeight = double.Parse(Console.ReadLine());            var tilePrice = double.Parse(Console.ReadLine());            var personSalary = double.Parse(Console.ReadLine());            var floorArea = floorHeight * floorWidth;            var tileArea = tileSide * tileHeight / 2;            var neededTiles = Math.Ceiling((floorArea / tileArea)) + 5;            var totalSum = (neededTiles * tilePrice) + personSalary;            if(totalSum <= budget)
            {
                Console.WriteLine($"{(budget - totalSum):f2} lv left.");
            }            else
            {
                Console.WriteLine($"You'll need {(totalSum - budget):f2} lv more.");
            }
        }
    }
}
