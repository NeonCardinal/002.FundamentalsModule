//Associative arrays - exercise, Task 001
//28.02.2024, 23:34

string str = Console.ReadLine();

Dictionary<char, int> occur =  new Dictionary<char, int>();

foreach(char ch in str)
{
    if(ch != ' ')
    {
        if(!occur.ContainsKey(ch))
        {
            occur.Add(ch, 1);
        }
        else
        {
            occur[ch]++;
        }
    }
}

foreach(var item in occur)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}