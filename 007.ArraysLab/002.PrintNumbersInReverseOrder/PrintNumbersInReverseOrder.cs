//Arrays - lab, Task 002
//07.02.2024, 18:41

int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for(int i = 0; i < arr.Length; i++)
{
    int number = int.Parse(Console.ReadLine());
    arr[i] = number;
}

for(int i = arr.Length - 1; i >= 0; i--)
{
    Console.Write($"{arr[i]} ");
}

Console.WriteLine();