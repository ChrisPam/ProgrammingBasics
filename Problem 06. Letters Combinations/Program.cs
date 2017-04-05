using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int startLetter = char.Parse(Console.ReadLine());
            int stopLetter = char.Parse(Console.ReadLine());
            int magicLetter = char.Parse(Console.ReadLine());
            var count = 0;
            for (int i = startLetter; i <= stopLetter; i++)
            {
                for (int j = startLetter; j <= stopLetter; j++)
                {
                    for (int k = startLetter; k <= stopLetter; k++)
                    {
                        var firstLetter = (char)i;
                        var secondLetter = (char)j;
                        var thirdLetter = (char)k;
                        if (firstLetter == magicLetter)
                        {
                            continue;
                        }
                        else if (secondLetter == magicLetter)
                        {
                            continue;
                        }
                        else if (thirdLetter == magicLetter)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("{0}{1}{2} ", (char)i, (char)j, (char)k);
                            count++;
                        }

                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
