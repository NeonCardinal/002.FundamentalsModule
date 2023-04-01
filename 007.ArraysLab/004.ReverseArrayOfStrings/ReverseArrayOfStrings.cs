//Arrays - lab, Task 004
//28.03.2023, 23:09
using System;

public class ReverseArrayOfStrings
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split();

        for(int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write($"{arr[i]} ");
        }

        Console.WriteLine();
    }
}