//Methods - exercise, Task 004
//17.02.2024, 17:55

string pass = Console.ReadLine();

if (!CheckPassLen(pass))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}
if (!CheckLetters(pass))
{
    Console.WriteLine("Password must consist only of letters and digits");
}
if (!CheckForMinDigitsCount(pass))
{
    Console.WriteLine("Password must have at least 2 digits");
}
if (CheckPassLen(pass) && CheckLetters(pass) && CheckForMinDigitsCount(pass))
{
    Console.WriteLine("Password is valid");
}

static bool CheckPassLen(string str)
{
    if (str.Length < 6 || str.Length > 10)
    {
        return false;
    }
    else
    {
        return true;
    }
}

static bool CheckLetters(string str)
{
    foreach (char ch in str)
    {
        if (!Char.IsLetterOrDigit(ch))
        {
            return false;
        }
    }

    return true;
}

static bool CheckForMinDigitsCount(string str)
{
    int digitsCount = 0;

    foreach (char ch in str)
    {
        if (Char.IsDigit(ch))
        {
            digitsCount++;
        }
    }

    return digitsCount >= 2;
}