//Arrays - exercise, Task 008
//08.02.2024, 21:28

int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] + arr[j] == n)
        {
            Console.WriteLine($"{arr[i]} {arr[j]}");
        }
    }
}