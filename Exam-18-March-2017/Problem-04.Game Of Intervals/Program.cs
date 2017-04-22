using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var result = 0.0;
        var before9 = 0.0;
        var before19 = 0.0;
        var before29 = 0.0;
        var before39 = 0.0;
        var before50 = 0.0;
        var invalid = 0.0;
        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            if (number > 50 || number < 0)
            {
                result = result / 2;
                invalid++;
            }
            else
            {
                if (number >= 0 && number <= 9)
                {
                    result = result + (number * 0.2);
                    before9++;
                }
                else if (number >= 10 && number <= 19)
                {
                    result = result + (number * 0.3);
                    before19++;
                }
                else if (number >= 20 && number <= 29)
                {
                    result = result + (number * 0.4);
                    before29++;
                }
                else if (number >= 30 && number <= 39)
                {
                    result = result + 50;
                    before39++;
                }
                else if (number >= 40 && number <= 50)
                {
                    result = result + 100;
                    before50++;
                }
            }
        }
        Console.WriteLine($"{result:F2}");
        Console.WriteLine($"From 0 to 9: {(before9 / n) * 100:F2}%");
        Console.WriteLine($"From 10 to 19: {(before19 / n) * 100:F2}%");
        Console.WriteLine($"From 20 to 29: {(before29 / n) * 100:F2}%");
        Console.WriteLine($"From 30 to 39: {(before39 / n) * 100:F2}%");
        Console.WriteLine($"From 40 to 50: {(before50 / n) * 100:F2}%");
        Console.WriteLine($"Invalid numbers: {(invalid / n) * 100:F2}%");
    }
}