//Basic syntax, conditional statements and loops - exercise, Task 004
//25.03.2023, 10:25
using System;

public class PrintAndSum
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int sum = 0;

        for(int i = start; i <= end; i++)
        {
            Console.Write($"{i} ");
            sum += i;
        }

        Console.WriteLine();
        Console.WriteLine($"Sum: {sum}");
    }
}