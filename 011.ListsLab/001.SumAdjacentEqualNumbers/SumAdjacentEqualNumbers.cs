//Lists - lab, Task 001
//28.05.2023, 14:54
using System;
using System.Collections.Generic;
using System.Linq;

public class SumAdjacentEqualNumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        for(int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                i = -1;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}