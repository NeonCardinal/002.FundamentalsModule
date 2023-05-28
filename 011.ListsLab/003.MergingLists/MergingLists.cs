//Lists - lab, Task 003
//28.05.2023, 16:20
using System;
using System.Collections.Generic;
using System.Linq;

public class MergingLists
{
    static void Main()
    {
        List<int> firstSerie = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondSerie = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> result = new List<int>();

        int max = Math.Max(firstSerie.Count, secondSerie.Count);

        for (int i = 0; i < max; i++)
        {
            if (i < firstSerie.Count)
            {
                result.Add(firstSerie[i]);
            }
            if (i < secondSerie.Count)
            {
                result.Add(secondSerie[i]);
            }
        }

        Console.WriteLine(String.Join(" ", result));
    }
}