//Arrays - exercise, Task 007
//08.02.2024, 21:21

int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int start = 0;
int len = 1;
int bestStart = 0;
int bestLen = 1;

for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] != arr[i + 1])
    {
        start = i + 1;
        len = 1;
    }
    else
    {
        len++;
    }

    if (len > bestLen)
    {
        bestLen = len;
        bestStart = start;
    }
}

for (int i = bestStart; i < bestStart + bestLen; i++)
{
    Console.Write($"{arr[i]} ");
}

Console.WriteLine();