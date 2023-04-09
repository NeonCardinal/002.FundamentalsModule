//Methods - lab, Task 008
//08.04.2023, 18:35
using System;

public class MathPower
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        Console.WriteLine(Power(number, power));
    }

    static double Power(double number, double power)
    {
        double result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        return result;
    }
}