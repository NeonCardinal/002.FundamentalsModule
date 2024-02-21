//List - exercise, Task 003
//21.02.2024, 21:54

int cmdCount = int.Parse(Console.ReadLine());
List<string> guests = new List<string>();

for(int i = 0; i < cmdCount; i++)
{
    string[] tokens = Console.ReadLine().Split(" ").ToArray();
    string name = tokens[0];

    if(tokens.Length == 3)
    {
        if(guests.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
            continue;
        }

        guests.Add(name);
    }
    else if(tokens.Length == 4)
    {
        if(!guests.Contains(name))
        {
            Console.WriteLine($"{name} is not in the list!");
            continue;
        }

        guests.Remove(name);
    }
}

Console.WriteLine(string.Join(System.Environment.NewLine, guests));