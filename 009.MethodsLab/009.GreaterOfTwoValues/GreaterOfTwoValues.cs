//Methods - lab, Task 009
//12.02.2024, 22:14

string type = Console.ReadLine();

int GetMax(int a, int b)
{
    return Math.Max(a, b);
}

char GetMax(char a, char b)
{
    char ch;

    if(a > b)
    {
        ch = a;
    }
    else
    {
        ch = b;
    }

    return ch;
}