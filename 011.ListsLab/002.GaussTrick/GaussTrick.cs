﻿//Lists - lab, Task 002
//28.05.2023, 15:38
using System;
using System.Collections.Generic;
using System.Linq;

public class GaussTrick
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> result = new List<int>();

        for (int i = 0; i < numbers.Count / 2; i++)
        {
            result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
        }

        if (numbers.Count % 2 != 0)
        {
            result.Add(numbers[numbers.Count / 2]);
        }

        Console.WriteLine(String.Join(" ", result));
    }
}