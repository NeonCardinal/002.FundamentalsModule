﻿//Arrays - lab, Task 008
//07.02.2024, 19:57

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int len = numbers.Length;

for (int i = 0; i < len - 1; i++)
{
    int[] condensed = new int[numbers.Length - 1];
    for (int j = 0; j < numbers.Length - 1; j++)
    {
        condensed[j] = numbers[j] + numbers[j + 1];
    }
    numbers = condensed;
}

Console.WriteLine(numbers[0]);