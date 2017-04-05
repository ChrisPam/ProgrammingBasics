using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            double firstDistance = speed * firstTime / 60;
            var firstDisanceSpeed = (speed + speed * 0.1);
            double secondDistance = firstDisanceSpeed * (secondTime / 60);
            double thirdDistance = (firstDisanceSpeed - (0.05 * firstDisanceSpeed)) * thirdTime / 60;

            var sum = firstDistance + secondDistance + thirdDistance;
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
