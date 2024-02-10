//Data types and variables - more exercise, Task 006
//07.05.2024, 15:56

long n = long.Parse(Console.ReadLine());
long openCount = 0;
long closeCount = 0;

for (int i = 1; i <= n; i++)
{
    string input = Console.ReadLine();
    if (input == "(")
    {
        openCount++;

    }
    else if (input == ")")
    {
        closeCount++;
        if (openCount - closeCount != 0)
        {
            Console.WriteLine("UNBALANCED");
            return;
        }
    }
}
if (openCount == closeCount)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}