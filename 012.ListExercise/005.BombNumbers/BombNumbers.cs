//List - exercise, Task 005
//21.02.2024, 22:17

List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
List<int> bomb = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

int bombNumber = bomb[0];
int bombPower = bomb[1];

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bombNumber)
    {
        int startIndex = i - bombPower;

        if (startIndex < 0)
        {
            startIndex = 0;
        }

        int endIndex = i + bombPower + 1;

        if (endIndex > numbers.Count)
        {
            endIndex = numbers.Count;
        }

        for (int j = startIndex; j < endIndex; j++)
        {
            numbers.RemoveAt(startIndex);
        }

        i--;
    }
}

Console.WriteLine(numbers.Sum());