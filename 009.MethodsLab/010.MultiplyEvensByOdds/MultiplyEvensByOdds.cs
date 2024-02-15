//Methods - lab, Task 010
//12.02.2024, 23:03

int n = int.Parse(Console.ReadLine());

int result = GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(n), GetSumOfOddDigits(n));

Console.WriteLine(result);

static int GetMultipleOfEvenAndOdds(int even, int odd)
{
    return even * odd;
}

static int GetSumOfEvenDigits(int number)
{
    int sum = 0;

    while (number != 0)
    {
        int currNumber = number % 10;

        if (currNumber % 2 == 0)
        {
            sum += number % 10;
        }

        number /= 10;
    }

    return sum;
}

static int GetSumOfOddDigits(int number)
{
    int sum = 0;

    while (number != 0)
    {
        int currNumber = number % 10;

        if (currNumber % 2 != 0)
        {
            sum += number % 10;
        }

        number /= 10;
    }

    return sum;
}