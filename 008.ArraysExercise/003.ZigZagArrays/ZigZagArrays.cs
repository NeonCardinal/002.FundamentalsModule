//Arrays - exercise, Task 003
//01.04.2023, 23:13
using System;
using System.Linq;

public class ZigZagArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] first = new int[n];
        int[] second = new int[n];

        for(int i = 1; i <= n; i++)
        {
            int[] tempArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if(i % 2 != 0)
            {
                first[i - 1] = tempArr[0];
                second[i - 1] = tempArr[1];
            }
            else
            {
                first[i - 1] = tempArr[1];
                second[i - 1] = tempArr[0];
            }
        }

        Console.WriteLine(String.Join(" ", first));
        Console.WriteLine(String.Join(" ", second));
    }
}