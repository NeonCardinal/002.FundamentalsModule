//Data types and variables - more exercise, Task 004
//07.02.2024, 15:50

int number = int.Parse(Console.ReadLine());

for (int i = 2; i <= number; i++)
{
    bool isPrime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine($"{i} -> true");
    }
    else
    {
        Console.WriteLine($"{i} -> false");
    }

}