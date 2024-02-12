//Arrays - exercise, Task 004
//08.02.2024, 19:57

int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rot = int.Parse(Console.ReadLine());

for(int i = 1; i <= rot; i++)
{
    int first = arr[0];

    for(int j = 0; j <= arr.Length - 2; j++)
    {
        arr[j] = arr[j + 1];
    }

    arr[arr.Length - 1] = first;
}

Console.WriteLine(string.Join(" ", arr));