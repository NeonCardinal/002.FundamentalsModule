//Associative arrays - exercise, Task 002
//28.02.2024, 23:43

int i = 1;
string currectKey = string.Empty;
Dictionary<string, int> resource  = new Dictionary<string, int>();

while(true)
{
    string input = Console.ReadLine();

    if(input == "stop")
    {
        break;
    }

    if(i % 2 != 0)
    {
        currectKey = input;
    }
    else
    {
        if(!resource.ContainsKey(currectKey))
        {
            resource.Add(currectKey, int.Parse(input));
        }
        else
        {
            resource[currectKey] += int.Parse(input);
        }
    }

    i++;
}

foreach(var item in resource)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}