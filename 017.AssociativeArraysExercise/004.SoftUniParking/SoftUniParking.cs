//Associative arrays - exercise, Task 004
//01.03.2024, 00:27

Dictionary<string, string> carsList = new Dictionary<string, string>();

int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    string[] tokens = input.Split(" ").ToArray();

    if(tokens.Length == 3)
    {
        if(!carsList.ContainsKey(tokens[1]))
        {
            carsList.Add(tokens[1], tokens[2]);
            Console.WriteLine($"{tokens[1]} registered {tokens[2]} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {carsList[tokens[1]]}");
        }
    }
    else if(tokens.Length == 2)
    {
        if(carsList.ContainsKey(tokens[1]))
        {
            carsList.Remove(tokens[1]);
            Console.WriteLine($"{tokens[1]} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {tokens[1]} not found");
        }
    }
}

foreach(var item in carsList)
{
    Console.WriteLine($"{item.Key} => {item.Value}");
}