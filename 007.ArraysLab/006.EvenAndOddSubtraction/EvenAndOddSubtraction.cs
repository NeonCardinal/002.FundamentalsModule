//Arrays - lab, Task 006
//07.02.2024, 19:42

int evenSum = 0;
int oddSum = 0;
int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for(int i = 0; i < arr.Length; i++)
{
    int curValur = arr[i];

    if(curValur % 2 == 0)
    {
        evenSum += curValur;
    }
    else
    {
        oddSum += curValur;
    }
}

int diff = evenSum - oddSum;

Console.WriteLine(diff);
