//Basic syntax, conditional statements and loops - lab, Task 009
//23.03.2023, 08:37
using System;

public class SumOfOddNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int cnt = 0;

        for (int i = 1; i <= 100; i += 2)
        {
            Console.WriteLine(i);

            sum += i;
            cnt++;

            if (cnt == n)
            {
                break;
            }
        }

        Console.WriteLine($"Sum: {sum}");
    }
}