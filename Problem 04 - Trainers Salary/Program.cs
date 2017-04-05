using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var lections = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            //Jelev", "RoYaL", "Roli", "Trofon" и "Sino"
            double forJelev = 0;
            double forRoYaL = 0;
            double forRoli = 0;
            double forTrofon = 0;
            double forSino = 0;
            double other = 0;
            for (int i = 0; i < lections; i++)
            {
                var lector = Console.ReadLine();
                if (lector == "Jelev")
                {
                    forJelev++;
                }
                else if (lector == "RoYaL")
                {
                    forRoYaL++;
                }
                else if (lector == "Roli")
                {
                    forRoli++;
                }
                else if (lector == "Trofon")
                {
                    forTrofon++;
                }
                else if (lector == "Sino")
                {
                    forSino++;
                }
                else
                {
                    other++;
                }
            }
            var salary = budget / lections;
            Console.WriteLine("Jelev salary: {0:F2} lv", forJelev * salary);
            Console.WriteLine("RoYaL salary: {0:F2} lv", forRoYaL * salary);
            Console.WriteLine("Roli salary: {0:F2} lv", forRoli * salary);
            Console.WriteLine("Trofon salary: {0:F2} lv", forTrofon * salary);
            Console.WriteLine("Sino salary: {0:F2} lv", forSino * salary);
            Console.WriteLine("Others salary: {0:F2} lv", other * salary);

        }
    }
}
