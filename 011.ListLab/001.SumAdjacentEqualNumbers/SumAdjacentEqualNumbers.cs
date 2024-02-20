//List - lab, Task 001
//17.02.2024, 18:54

List<double> numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

for(int i = 0; i < numbers.Count - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
    {
        numbers[i] += numbers[i + 1];
        numbers.RemoveAt(i + 1);
        i = -1;
    }
}

Console.WriteLine(string.Join(" ", numbers));