//Basic syntax, con statements and loops, Task 011
//26.01.2024, 19:15

int number = int.Parse(Console.ReadLine());
int multiplier = int.Parse(Console.ReadLine());

if (multiplier > 10)
{
    Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
}
else
{
    for (int i = multiplier; i <= 10; i++)
    {
        Console.WriteLine($"{number} X {i} = {number * i}");
    }
}