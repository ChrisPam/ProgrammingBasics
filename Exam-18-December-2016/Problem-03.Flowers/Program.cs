using System;

class Program
{
    static void Main()
    {
        var brHrizantemi = int.Parse(Console.ReadLine());
        var brRozi = int.Parse(Console.ReadLine());
        var brLaleta = int.Parse(Console.ReadLine());
        var season = Console.ReadLine().ToLower();
        var praznik = Console.ReadLine().ToLower();

        var priceHrizantemi = 0.0;
        var priceRozi = 0.0;
        var priceLaleta = 0.0;
        var priceTotal = 0.0;

        if (season == "spring" || season == "summer")
        {
            priceHrizantemi = 2;
            priceRozi = 4.1;
            priceLaleta = 2.5;
        }
        else if (season == "autumn" || season == "winter")
        {
            priceHrizantemi = 3.75;
            priceRozi = 4.5;
            priceLaleta = 4.15;
        }

        priceTotal = (priceHrizantemi * brHrizantemi) + (priceRozi * brRozi) + (priceLaleta * brLaleta);

        if (praznik == "y")
        {
            priceTotal = priceTotal + priceTotal * 0.15;
        }

        if (season == "spring" && brLaleta > 7)
        {
            priceTotal = priceTotal - priceTotal * 0.05;
        }

        if (season == "winter" && brRozi >= 10)
        {
            priceTotal = priceTotal - priceTotal * 0.1;
        }
        if (brHrizantemi + brLaleta + brRozi > 20)
        {
            priceTotal = priceTotal - priceTotal * 0.2;
        }



        priceTotal += 2;

        Console.WriteLine("{0:f2}", priceTotal);
    }
}