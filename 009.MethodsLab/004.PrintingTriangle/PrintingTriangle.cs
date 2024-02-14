//Methods - lab, Task 004
//11.02.2024, 22:00

int n = int.Parse(Console.ReadLine());

void PrintLine(int start, int end)
{
    for(int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}

void Print(int n)
{
    for(int i = 1; i <= n; i++)
    {
        PrintLine(1, i);
    }

    for(int i = n - 1; i >= 1; i--)
    {
        PrintLine(1, i);
    }
}

Print(n);