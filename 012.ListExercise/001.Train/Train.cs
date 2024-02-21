//List - exercise, Task 001
//21.02.2024, 20:59

List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int wagonCapacity = int.Parse(Console.ReadLine());

while(true)
{
    string input = Console.ReadLine();

    if(input == "end")
    {
        Console.WriteLine(string.Join(" ", wagons));
        break;
    }

    string[] tokens = input.Split(" ").ToArray();

    if(tokens.Length == 2)
    {
        wagons.Add(int.Parse(tokens[1]));
    }
    else if(tokens.Length == 1)
    {
        int passangers = int.Parse(tokens[0]);

        for(int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passangers <= wagonCapacity)
            {
                wagons[i] += passangers;
                passangers = 0;
            }
        }
    }
}


