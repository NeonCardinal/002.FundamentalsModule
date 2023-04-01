//Arrays - lab, Task 006
//28.03.2023, 23:15
using System;
using System.Linq;

public class EvenAndOddSubtraction
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int evenSum = 0;
        int oddSum = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            int number = arr[i];

            if(number % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }

        Console.WriteLine(evenSum - oddSum);
    }
}