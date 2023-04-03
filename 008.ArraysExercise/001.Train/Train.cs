//Arrays - exercise, Task 001
//01.04.2023, 23:05
using System;

public class Train
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int[] arr = new int[n];

        for(int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine(String.Join(" ", arr));
        Console.WriteLine(sum);
    }
}