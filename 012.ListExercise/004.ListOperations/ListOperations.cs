//List - exercise, Task 004
//21.02.2024, 22:02

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        break;
    }

    string[] tokens = command.Split();

    if (tokens[0] == "Add")
    {
        int number = int.Parse(tokens[1]);
        numbers.Add(number);
    }
    else if (tokens[0] == "Insert")
    {
        int number = int.Parse(tokens[1]);
        int index = int.Parse(tokens[2]);
        if (index <= -1 || index >= numbers.Count)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.Insert(index, number);
        }
    }
    else if (tokens[0] == "Remove")
    {
        int index = int.Parse(tokens[1]);
        if (index <= -1 || index >= numbers.Count)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.RemoveAt(index);
        }
    }
    else if (tokens[1] == "left")
    {
        int count = int.Parse(tokens[2]);
        ShiftLeft(numbers, count);
    }
    else if (tokens[1] == "right")
    {
        int count = int.Parse(tokens[2]);
        ShiftRight(numbers, count);
    }
}

Console.WriteLine(string.Join(" ", numbers));

static void ShiftLeft(List<int> list, int count)
{
    for (int i = 0; i < count; i++)
    {
        int temp = list[0];
        list.Add(temp);
        list.RemoveAt(0);
    }
}

static void ShiftRight(List<int> list, int count)
{
    for (int i = 0; i < count; i++)
    {
        int temp = list[list.Count - 1];
        list.Insert(0, temp);
        list.RemoveAt(list.Count - 1);
    }
}