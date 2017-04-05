using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dcoder
{
    public class Program
    {
        public static void Main()
        {
            var startNumber = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());
            var maxCombinations = int.Parse(Console.ReadLine());
            var check = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    if (check != maxCombinations)
                    {
                        Console.Write("<{0}-{1}>", i, j);
                        check++;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}