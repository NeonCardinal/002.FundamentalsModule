//Methods - exercise, Task 008
//08.05.2023, 17:08
using System;

public class FactorialDivision
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        double firstResult = CalcutaleFactoriel(firstNumber);
        double secondResult = CalcutaleFactoriel(secondNumber);

        Console.WriteLine($"{(firstResult / secondResult):F2}");
    }

    static double CalcutaleFactoriel(int number)
    {
        double result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}