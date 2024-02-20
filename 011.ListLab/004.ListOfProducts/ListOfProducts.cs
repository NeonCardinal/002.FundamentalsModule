//List - lab, Task 004
//17.02.2024, 19:20

List<string> products = new List<string>();

int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string product = Console.ReadLine();
    products.Add(product);
}

products.Sort();

for(int i = 0; i < products.Count; i++)
{
    int index = i + 1;

    Console.WriteLine($"{index}.{products[i]}");
}