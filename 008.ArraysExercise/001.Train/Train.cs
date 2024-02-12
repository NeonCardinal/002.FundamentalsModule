//Arrays - exericse, Task 001
//08.02.2024, 19:42

int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int sum = 0;

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    sum += arr[i];
}

Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(sum);