//List - exercise, Task 002
//21.02.2024, 21:39

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while(true)
{
    string input = Console.ReadLine();

    if(input == "end")
    {
        Console.WriteLine(string.Join(" ", numbers));
        break;
    }

    string[] tokens = input.Split(" ").ToArray();
    string cmd = tokens[0];

    if(cmd == "Delete")
    {
        numbers.RemoveAll(x => x == int.Parse(tokens[1]));
    }
    else if(cmd == "Insert")
    {
        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
    }
}