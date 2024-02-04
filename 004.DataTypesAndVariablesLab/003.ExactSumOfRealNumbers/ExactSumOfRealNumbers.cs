//Data types and variables, Task 003
//01.02.2024, 20:27

int n = int.Parse(Console.ReadLine());

decimal sum = 0.0m;

for(int i = 0; i < n; i++)
{
    decimal number = decimal.Parse(Console.ReadLine());

    sum += number;
}

Console.WriteLine(sum);