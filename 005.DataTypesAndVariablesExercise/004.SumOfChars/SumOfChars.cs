//Data types and variables - exercise, Task 004
//04.02.2024, 14:00

int n = int.Parse(Console.ReadLine());

int sum = 0;

for(int i = 0; i < n; i++)
{
    char ch = char.Parse(Console.ReadLine());

    sum += (int)ch;
}

Console.WriteLine($"The sum equals: {sum}");