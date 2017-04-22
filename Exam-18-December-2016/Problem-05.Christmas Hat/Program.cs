using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('.', n * 2 - 1) + "/|\\" + new string('.', n * 2 - 1));
        Console.WriteLine(new string('.', n * 2 - 1) + "\\|/" + new string('.', n * 2 - 1));
        var dotCount = n * 2 - 1;
        var dashCount = 0;
        for (int i = 0; i < n * 2; i++)
        {

            Console.WriteLine(new string('.', dotCount) + "*" + new string('-', dashCount) + "*" + new string('-', dashCount) + "*" + new string('.', dotCount));
            dotCount--;
            dashCount++;
        }
        Console.WriteLine(new string('*', 4 * n + 1));
        for (int i = 0; i < n * 2; i++)
        {
            Console.Write("*");
            if (i != n * 2)
            {
                Console.Write(".");
            }
            if (i == n * 2 - 1)
            {
                Console.WriteLine("*");
            }

        }
        Console.WriteLine(new string('*', 4 * n + 1));
    }
}