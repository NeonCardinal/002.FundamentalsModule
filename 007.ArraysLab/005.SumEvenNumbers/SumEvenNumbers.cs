//Arrays - lab, Task 005
//07.02.2024, 19:03

int sum = 0;
int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for(int i = 0; i < arr.Length; i++)
{
    int curValue = arr[i];
    if(curValue % 2 == 0)
    {
        sum += curValue;
    }
}

Console.WriteLine(sum);