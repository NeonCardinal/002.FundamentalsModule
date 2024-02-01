//Basic syntax, con statements and loops - exercise, Task 004
//27.01.2024, 12:15

int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int sum = 0;

for(int i = start; i <= end; i++)
{
    Console.Write($"{i} ");
    sum += i;
}

Console.WriteLine();
Console.WriteLine($"Sum: {sum}");