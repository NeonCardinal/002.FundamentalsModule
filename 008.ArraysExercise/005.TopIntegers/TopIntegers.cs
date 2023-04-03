//Arrays - exercise, Task 005
//02.04.2023, 15:51
using System;
using System.Linq;

public class TopIntegers
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string greater = "";

        for (int i = 0; i < arr.Length; i++)
        {
            int currentElement = arr[i];
            bool isGreater = true;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] >= currentElement)
                {
                    isGreater = false;
                    break;
                }
            }

            if (isGreater)
            {
                greater += currentElement + " ";
            }
        }

        Console.WriteLine(greater);
    }
}