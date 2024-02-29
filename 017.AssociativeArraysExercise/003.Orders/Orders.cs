//Associative arrays - exercise, Task 003
//01.03.2024, 00:04

Dictionary<string, double> orders = new Dictionary<string, double>();
Dictionary<string, int> ordesQuantity = new Dictionary<string, int>();

while(true)
{
    string input = Console.ReadLine();

    if(input == "buy")
    {
        break;
    }

    string[] tokens = input.Split(" ").ToArray();
    string product = tokens[0];
    double price = double.Parse(tokens[1]);
    int quantity = int.Parse(tokens[2]);

    if(!orders.ContainsKey(product))
    {
        orders.Add(product, price);
    }
    else
    {
        if(orders[product] != price)
        {
            orders[product] = price;
        }
    }

    if(!ordesQuantity.ContainsKey(product))
    {
        ordesQuantity.Add(product, quantity);
    }
    else
    {
        ordesQuantity[product] += quantity;
    }
}

foreach(var item in ordesQuantity)
{
    if(orders.ContainsKey(item.Key))
    {
        orders[item.Key] *= item.Value;
    }
}

foreach(var item in orders)
{
    Console.WriteLine($"{item.Key} -> {item.Value:F2}");
}