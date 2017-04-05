using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02___Work_hourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int persons = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            var personsWorkHours = persons * days * 8;

            if (personsWorkHours >= neededHours)
            {
                var leftHours = personsWorkHours - neededHours;
                Console.WriteLine($"{leftHours} hours left");
            }
            else if (personsWorkHours < neededHours)
            {
                var moreWorkHours = neededHours - personsWorkHours;
                Console.WriteLine($"{moreWorkHours} overtime");
                var penalties = moreWorkHours * days;
                Console.WriteLine($"Penalties: {penalties}");
            }
        }
    }
}
