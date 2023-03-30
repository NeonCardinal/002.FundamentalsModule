//Data types and variables - exercise, Task 008
//26.03.2023, 19:52
using System;

public class BeerKegs
{
    static void Main()
    {
        int n;
        double greater = double.MinValue;
        string greaterModel = string.Empty;

        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;

            if (volume >= greater)
            {
                greater = volume;
                greaterModel = model;
            }
        }

        Console.WriteLine(greaterModel);
    }
}