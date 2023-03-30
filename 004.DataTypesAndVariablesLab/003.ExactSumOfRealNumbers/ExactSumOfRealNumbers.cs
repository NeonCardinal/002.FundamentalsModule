//Data types and variables - lab, Task 003
//26.03.2023, 00:10
using System;

public class ExactSumOfRealNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal sum = 0.00M;

        for(int i = 0; i < n; i++)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine(sum);
    }
}