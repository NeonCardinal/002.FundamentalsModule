//Arrays - lab, Task 004
//07.02.2024, 19:01

string[] arr = Console.ReadLine().Split(" ").ToArray();

Array.Reverse(arr);

Console.WriteLine(string.Join(" ", arr));