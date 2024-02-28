//Associative arrays - lab, Task 001
//28.02.2024, 22:45

int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

SortedDictionary<int, int> occur = new SortedDictionary<int, int>();

foreach(var item in numbers)
{
    if(!occur.ContainsKey(item))
    {
        occur.Add(item, 1);
    }
    else
    {
        occur[item]++;
    }
}

foreach(var item in occur)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}