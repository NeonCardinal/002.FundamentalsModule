//Associative arrays - lab, Task 002
//28.02.2024, 23:04

string[] words = Console.ReadLine().Split(" ").ToArray();

Dictionary<string, int> count = new Dictionary<string, int>();

foreach(var word in words)
{
    string wordToLower = word.ToLower();

    if(!count.ContainsKey(wordToLower))
    {
        count.Add(wordToLower, 1);
    }
    else
    {
        count[wordToLower]++;
    }
}

foreach(var word in count)
{
    if(word.Value % 2 != 0)
    {
        Console.Write($"{word.Key} ");
    }
}