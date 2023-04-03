//Arrays - exercise, Task 004
//01.04.2023, 23:21
using System;
using System.Linq;

public class ArrayRotation
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rotations = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rotations; i++)
        {
            int firstElement = array[0];

            for (int j = 0; j <= array.Length - 2; j++)
            {
                array[j] = array[j + 1];
            }

            array[array.Length - 1] = firstElement;
        }

        Console.WriteLine(string.Join(" ", array));
    }
}