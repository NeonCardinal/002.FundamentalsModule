//Data types and variables - lab, Task 003
//28.03.2023, 23:06
using System;
using System.Linq;

public class RoundingNumbers
{
    static void Main()
    {
        double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} => ");

            arr[i] = Math.Round(arr[i], MidpointRounding.AwayFromZero);

            Console.WriteLine($"{arr[i]}");
        }
    }
}