//Arrays - lab, Task 002
//28.03.2023, 23:02
using System;

public class PrintNumbersInReverseOrder
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            arr[i] = number;
        }

        for(int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write($"{arr[i]} ");
        }

        Console.WriteLine();
    }
}