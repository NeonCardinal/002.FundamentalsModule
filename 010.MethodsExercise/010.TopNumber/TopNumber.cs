//Methods - exerise, Task 010
//17.02.2024, 18:41

int n = int.Parse(Console.ReadLine());

PrintTopNumber(n);

static bool IsTopNumber(int n)
{
    bool isOdd = false;
    bool isDivideble = false;
    int sum = 0;

    while (n != 0)
    {
        int temp = n % 10;

        if (temp % 2 != 0)
        {
            isOdd = true;
        }

        sum += temp;
        n = n / 10;
    }

    if (sum % 8 == 0)
    {
        isDivideble = true;
    }

    if (isOdd && isDivideble)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void PrintTopNumber(int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (IsTopNumber(i))
        {
            Console.WriteLine(i);
        }
    }
}