//Arrays - lab, Task 003
//07.02.2024, 18:54

double[] arr = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

for(int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} => ");

    arr[i] = Math.Round(arr[i], MidpointRounding.AwayFromZero);

    Console.WriteLine($"{arr[i]}");
}