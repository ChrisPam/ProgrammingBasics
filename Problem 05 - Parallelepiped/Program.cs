using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05___Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var topAndBot = new string('~', n - 2);
            var topAndBotDot = new string('.', (n * 2) + 1);
            var strana3d = topAndBot;
            Console.WriteLine("+" + topAndBot + "+" + topAndBotDot);
            Console.WriteLine("|" + "\\" + strana3d + "\\" + new string('.', n * 2));

            var leftDots = 1;
            var rightDots = n * 2 - 1;
            for (int i = 1; i < n * 2 + 1; i++)
            {
                Console.WriteLine("|" + new string('.', leftDots) + "\\" + strana3d + "\\" + new string('.', rightDots));
                leftDots++;
                rightDots--;
            }
            Console.WriteLine("\\" + new string('.', n *2) + "|" +  strana3d + "|");
            var leftDotss = 1;
            var rightDotss = 2 * n - 1;
            for (int i = 1; i <= n * 2; i++)
            {
                Console.WriteLine(new string('.', leftDotss) + "\\" + new string('.', rightDotss) + "|" + strana3d + "|");
                leftDotss++;
                rightDotss--;
            }

            Console.WriteLine(topAndBotDot + "+" + topAndBot + "+");
        }
    }
}
