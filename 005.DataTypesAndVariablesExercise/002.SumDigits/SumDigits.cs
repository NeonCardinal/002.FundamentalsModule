//Data types and variables - exercise, Task 002
//26.03.2023, 12:15
using System;

public class SumDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        while(number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine(sum);
    }
}