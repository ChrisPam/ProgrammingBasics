using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double pricePeralnq = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            var toys = 0;
            var money = 0;
            var sumMoney = 0;
            var brat = 0;
            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    money += 10;
                    sumMoney = money + sumMoney;
                    brat++;
                }
                else
                {
                    toys++;
                }
            }

            var toysPrice = toys * p;
            var sum = (toysPrice + sumMoney) - brat;

            if(sum > pricePeralnq)
            {
                Console.WriteLine("Yes! {0}", sum - pricePeralnq);
            }
            else
            {
                Console.WriteLine("No! {0}", pricePeralnq - sum);
            }
        }
    }
}
