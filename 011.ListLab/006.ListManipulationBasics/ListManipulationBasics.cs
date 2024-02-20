//List - lab, Task 006
//17.02.2024, 19:35

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while(true)
{
    string cmd = Console.ReadLine().ToLower();

    if(cmd == "end")
    {
        Console.WriteLine(string.Join(" ", numbers));
        break;
    }

    string[] tokens = cmd.Split(" ").ToArray();
    string command = tokens[0];

    if(command == "add")
    {
        numbers.Add(int.Parse(tokens[1]));
    }
    else if(command == "remove")
    {
        numbers.Remove(int.Parse(tokens[1]));
    }
    else if(command == "removeat")
    {
        numbers.RemoveAt(int.Parse(tokens[1]));
    }
    else if(command == "insert")
    {
        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
    }
}