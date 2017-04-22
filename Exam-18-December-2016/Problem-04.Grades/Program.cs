using System;

class Program
{
    static void Main()
    {
        var students = int.Parse(Console.ReadLine());

        double topStudents = 0;
        double betweenFourAndFive = 0;
        double betweenThreenAndFour = 0;
        double failStudents = 0;

        double sum = 0;

        for (int i = 1; i <= students; i++)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5)
            {
                topStudents++;
            }
            else if (grade < 5 && grade >= 4)
            {
                betweenFourAndFive++;
            }
            else if (grade < 4 && grade >= 3)
            {
                betweenThreenAndFour++;
            }
            else if (grade < 3)
            {
                failStudents++;
            }
            sum += grade;
        }
        double average = sum / students;

        Console.WriteLine($"Top students: {(topStudents / students * 100):f2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {(betweenFourAndFive / students * 100):f2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {(betweenThreenAndFour / students * 100):f2}%");
        Console.WriteLine($"Fail: {(failStudents / students * 100):f2}%");
        Console.WriteLine($"Average: {average:f2}");
    }
}