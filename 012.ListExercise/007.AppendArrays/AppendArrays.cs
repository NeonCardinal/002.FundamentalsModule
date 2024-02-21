//List - exercise, Task 007
//21.02.2024, 22:26

List<string> items = Console.ReadLine().Split('|').ToList();

items.Reverse();

List<string> result = new List<string>();

for (int i = 0; i < items.Count; i++)
{
    List<string> numbers = items[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

    for (int j = 0; j < numbers.Count; j++)
    {
        result.Add(numbers[j]);
    }
}

Console.WriteLine(string.Join(" ", result));