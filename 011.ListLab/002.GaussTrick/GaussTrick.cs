//List - lab, Task 002
//17.02.2024, 19:03

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> result = new();

for (int i = 0; i < numbers.Count / 2; i++)
{
    result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
}

if (numbers.Count % 2 != 0)
{
    result.Add(numbers[numbers.Count / 2]);
}

Console.WriteLine(String.Join(" ", result));