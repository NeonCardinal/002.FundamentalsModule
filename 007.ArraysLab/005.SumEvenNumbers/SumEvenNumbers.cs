//Arrays - lab, Task 005
//28.03.2023, 23:11
using System;
using System.Linq;

public class SumEvenNumbers
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int sum = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] % 2 == 0)
            {
                sum += arr[i];
            }
        }

        Console.WriteLine(sum);
    }
}