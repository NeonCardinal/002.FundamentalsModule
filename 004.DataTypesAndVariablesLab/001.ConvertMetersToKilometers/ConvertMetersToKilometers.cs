//Data types and variables - lab, Task 001
//25.03.2023, 23:59
using System;

public class ConvertMetersToKilometers
{
    static void Main()
    {
        int meters = int.Parse(Console.ReadLine());

        double kilometers = meters / 1000.00;

        Console.WriteLine($"{kilometers:F2}");
    }
}