using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string firstcurrency = Console.ReadLine();
            string secondcurrency = Console.ReadLine();
            decimal firstvalue = 0.0m;
            decimal secondvalue = 0.0m;
            if (firstcurrency == "BGN")
            {
                firstvalue = 1;
            }
            else if (firstcurrency == "USD")
            {
                firstvalue = 1.79549m;
            }
            else if (firstcurrency == "EUR")
            {
                firstvalue = 1.95583m;
            }
            else if (firstcurrency == "GBP")
            {
                firstvalue = 2.53405m;
            }

            if (secondcurrency == "BGN")
            {
                secondvalue = 1;
            }
            else if (secondcurrency == "USD")
            {
                secondvalue = 1.79549m;
            }
            else if (secondcurrency == "EUR")
            {
                secondvalue = 1.95583m;
            }
            else if (secondcurrency == "GBP")
            {
                secondvalue = 2.53405m;
            }
            decimal result = money * (firstvalue / secondvalue);

            Console.WriteLine("{0} {1}", Math.Round(result, 2), secondcurrency);
        }
    }
}
