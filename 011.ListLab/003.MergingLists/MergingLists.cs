//List - lab, Task 003
//17.02.2024, 19:14

List<int> firstSerie = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondSerie = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> result = new List<int>();

int max = Math.Max(firstSerie.Count, secondSerie.Count);

for (int i = 0; i < max; i++)
{
    if (i < firstSerie.Count)
    {
        result.Add(firstSerie[i]);
    }
    if (i < secondSerie.Count)
    {
        result.Add(secondSerie[i]);
    }
}

Console.WriteLine(String.Join(" ", result));