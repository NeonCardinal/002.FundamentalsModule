//Basic syntax, conditional statements and loops - more exercise, Task 001
//25.03.2023, 11:27
using System;

public class SortNumbers
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int[] arr = new int[3];

        arr[0] = first;
        arr[1] = second;
        arr[2] = third;
        Array.Sort(arr);
        Array.Reverse(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}