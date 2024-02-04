//Data types and variables - lab, Task 005
//01.02.2024, 20:40

int n = int.Parse(Console.ReadLine());


for(int i = 1; i <= n; i++)
{
    int num = i;
    int sum = 0;

    while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
    }

    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}