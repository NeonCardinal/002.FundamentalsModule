//Basic syntax, con statements and loops, Task 009
//26.01.2024, 18:56

int n = int.Parse(Console.ReadLine());

int sum = 0;
int cnt = 0;

for (int i = 1; i <= 100; i += 2)
{
    Console.WriteLine(i);

    sum += i;
    cnt++;

    if (cnt == n)
    {
        break;
    }
}

Console.WriteLine($"Sum: {sum}");