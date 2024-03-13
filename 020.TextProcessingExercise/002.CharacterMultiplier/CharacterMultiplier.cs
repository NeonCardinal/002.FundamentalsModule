//Text processing - exercise, Task 002
//11.03.2024, 22:16

string[] strs = Console.ReadLine().Split();

int result = Multiply(strs[0], strs[1]);

Console.WriteLine(result);

static int Multiply(string first, string second)
{
    int sum = 0;

    for (int i = 0; i < Math.Max(first.Length, second.Length); i++)
    {
        if (i < first.Length && i < second.Length)
        {
            sum += (int)first[i] * (int)second[i];
        }
        else if (i < first.Length && i >= second.Length)
        {
            sum += (int)first[i];
        }
        else if (i >= first.Length && i <= second.Length)
        {
            sum += (int)second[i];
        }
    }

    return sum;
}