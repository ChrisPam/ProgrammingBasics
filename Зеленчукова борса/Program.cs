using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());

            double VegetablesSumValue = priceVegetables * kgVegetables;
            double FruitsSumValue = priceFruits * kgFruits;

            double bothSumValue = VegetablesSumValue + FruitsSumValue;
            double bothSumValueInEur = bothSumValue / 1.94;

            Console.WriteLine(bothSumValueInEur);

        }
    }
}
