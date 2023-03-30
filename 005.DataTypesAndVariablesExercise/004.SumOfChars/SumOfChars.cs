//Data types and variables - exercise, Task 004
//26.03.2023, 12:25
using System;

public class SumOfChars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for(int i = 0; i < n; i ++)
        {
            char ch = char.Parse(Console.ReadLine());

            sum += (int)ch;
        }

        Console.WriteLine($"The sum equals: {sum}");
    }
}