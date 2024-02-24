//Objects and classes - lab, Task 001
//21.02.2024, 22:39

using System;

string[] words = Console.ReadLine().Split(" ").ToArray();

Random rnd = new Random();

for (int i = 0; i < words.Length; i++)
{
    int rndIndex = rnd.Next(0, words.Length);
    string temp = words[i];
    words[i] = words[rndIndex];
    words[rndIndex] = temp;
}

foreach (var item in words)
{
    Console.WriteLine(item);
}