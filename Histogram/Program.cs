using System;


namespace _04.histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());


                if (number >= 800)
                {
                    p5 = p5 + 1;
                }

                else if (number >= 600)
                {
                    p4 = p4 + 1;
                }

                else if (number >= 400)
                {
                    p3 = p3 + 1;
                }

                else if (number >= 200)
                {
                    p2 = p2 + 1;
                }

                else
                {
                    p1 = p1 + 1;
                }
            }
            Console.WriteLine("{0:F2}%", p1 * 100 / n);
            Console.WriteLine("{0:F2}%", p2 * 100 / n);
            Console.WriteLine("{0:F2}%", p3 * 100 / n);
            Console.WriteLine("{0:F2}%", p4 * 100 / n);
            Console.WriteLine("{0:F2}%", p5 * 100 / n);



        }
    }
}