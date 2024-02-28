//Associative arrays - lab, Task 004
//28.02.2024, 23:19

string[] words = Console.ReadLine().Split(" ").Where(x => x.Length % 2 == 0).ToArray();

Console.WriteLine(string.Join("\r\n", words));