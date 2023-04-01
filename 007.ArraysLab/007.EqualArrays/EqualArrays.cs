//Arrays - lab, Task 007
//28.03.2023, 23:18
using System;
using System.Linq;

public class EqualArrays
{
    static void Main()
    {
        int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for(int i = 0; i < first.Length; i++)
        {
            if(first[i] != second[i])
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
            }
        }
    }
}