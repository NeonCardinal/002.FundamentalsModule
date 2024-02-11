//Arrays - lab, Task 007
//07.02.2024, 19:49

using System;

int[] firstArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isEq = true;
int sum = 0;

for(int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i] != secondArr[i])
    {
        isEq = false;
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        break;
    }
    else
    {
        isEq = true;
        sum += firstArr[i];
    }
}

if(isEq)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}