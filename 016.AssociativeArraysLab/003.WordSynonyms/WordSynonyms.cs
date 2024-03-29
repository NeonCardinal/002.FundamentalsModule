﻿//Associative arrays - lab, Task 003
//28.02.2024, 23:10

int n = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

for(int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if(!words.ContainsKey(word))
    {
        words.Add(word, new List<string>());
    }

    words[word].Add(synonym);

}

foreach(var item in words)
{
    Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
}