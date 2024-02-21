//List - exercise, Task 006
//21.02.2024, 22:20

List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
int firstPlayerScore = 0;
int secondPlayerScore = 0;

for (int i = 0; i < firstPlayerCards.Count; i++)
{
    if (firstPlayerCards[i] > secondPlayerCards[i])
    {
        firstPlayerCards.Add(secondPlayerCards[i]);
        firstPlayerCards.Add(firstPlayerCards[i]);
        firstPlayerScore += (firstPlayerCards[i] + secondPlayerCards[i]);
        firstPlayerCards.RemoveAt(0);
        secondPlayerCards.RemoveAt(0);
    }
    else if (firstPlayerCards[i] < secondPlayerCards[i])
    {
        secondPlayerCards.Add(firstPlayerCards[i]);
        secondPlayerCards.Add(secondPlayerCards[i]);
        secondPlayerScore += (firstPlayerCards[i] + secondPlayerCards[i]);
        firstPlayerCards.RemoveAt(0);
        secondPlayerCards.RemoveAt(0);
    }
    else if (firstPlayerCards[i] == secondPlayerCards[i])
    {
        firstPlayerCards.RemoveAt(0);
        secondPlayerCards.RemoveAt(0);
    }

    i--;

    if (firstPlayerCards.Count == 0)
    {
        Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
        break;
    }
    if (secondPlayerCards.Count == 0)
    {
        Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
        break;
    }
}