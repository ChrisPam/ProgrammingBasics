using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Парички
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double iana = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            var bitcoinsInLev = bitcoins * 1168;
            var ianaInLev = (iana * 0.15) * 1.76;

            var bothSum = bitcoinsInLev + ianaInLev;
            var bothSumInEur = bothSum / 1.95;

            var comisionValue = (bothSumInEur * comision) / 100;

            var resultValue = bothSumInEur - comisionValue;
            Console.WriteLine(resultValue);
        }
    }
}
