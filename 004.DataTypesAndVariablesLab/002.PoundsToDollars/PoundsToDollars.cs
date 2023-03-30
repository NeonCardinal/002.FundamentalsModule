//Data types and variables - lab, Task 002
//26.03.2023, 00:07
using System;

public class PoundsToDollars
{
    static void Main()
    {
        decimal pounds = decimal.Parse(Console.ReadLine());

        decimal dollars = pounds * 1.31M;

        Console.WriteLine($"{dollars:F3}");
    }
}