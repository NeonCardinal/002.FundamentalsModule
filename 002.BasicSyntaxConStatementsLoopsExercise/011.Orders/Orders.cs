//Basic syntax, con statements and loops - exercise, Task 011
//30.01.2024, 23:01

int n = int.Parse(Console.ReadLine());

double sum = 0.0;

for(int i = 0; i < n; i++)
{
    double capsulePrice = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsuleCnt = int.Parse(Console.ReadLine());

    double price = days * capsuleCnt * capsulePrice;
    sum += price;

    Console.WriteLine($"The price for the coffee is: ${price:F2}");
}

Console.WriteLine($"Total: ${sum:F2}");
