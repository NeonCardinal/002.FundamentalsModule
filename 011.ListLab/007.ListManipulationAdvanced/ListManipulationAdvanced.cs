//List - lab, Task 007
//17.02.2024, 19:44

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
bool isChanged = false;

while (true)

{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }

    string[] tokens = command.Split();

    switch (tokens[0])
    {
        case "Add":
            {
                int n = int.Parse(tokens[1]);
                numbers.Add(n);
                isChanged = true;
            }
            break;
        case "Remove":
            {
                int numberToRemove = int.Parse(tokens[1]);
                numbers.Remove(numberToRemove);
                isChanged = true;
            }
            break;
        case "RemoveAt":
            {
                int index = int.Parse(tokens[1]);
                numbers.RemoveAt(index);
                isChanged = true;
            }
            break;
        case "Insert":
            {
                int index = int.Parse(tokens[2]);
                int value = int.Parse(tokens[1]);
                numbers.Insert(index, value);
                isChanged = true;
            }
            break;
        case "Contains":
            {
                int number = int.Parse(tokens[1]);
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No such number");
                }
            }
            break;
        case "PrintEven":
            {
                Even(numbers);
            }
            break;
        case "PrintOdd":
            {
                Odd(numbers);
            }
            break;
        case "GetSum":
            {
                Console.WriteLine(numbers.Sum());
            }
            break;
        case "Filter":
            {
                int numberToCompare = int.Parse(tokens[2]);
                List<int> result = Filtering(numbers, tokens[1], numberToCompare);
                Console.WriteLine(String.Join(" ", result));
            }
            break;
    }
}

if (isChanged)
{
    Console.WriteLine(String.Join(" ", numbers));
}

static void Even(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            Console.Write($"{numbers[i]} ");
        }
    }

    Console.WriteLine();
}

static void Odd(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] % 2 != 0)
        {
            Console.Write($"{numbers[i]} ");
        }
    }

    Console.WriteLine();
}

static List<int> Filtering(List<int> list, string filter, int number)
{
    if (filter == "<")
    {
        List<int> result = list.FindAll(x => x < number);
        return result;
    }
    else if (filter == ">")
    {
        List<int> result = list.FindAll(x => x > number);
        return result;
    }
    else if (filter == "<=")
    {
        List<int> result = list.FindAll(x => x <= number);
        return result;
    }
    else if (filter == ">=")
    {
        List<int> result = list.FindAll(x => x >= number);
        return result;
    }
    else
    {
        return list;
    }
}