//Text processing - lab, Task 005
//10.03.2024, 16:52

using System.Runtime.Remoting;

string str = Console.ReadLine();

string digits = string.Empty;
string letters = string.Empty;
string others = string.Empty;

for(int i = 0; i < str.Length; i++)
{
    if(char.IsDigit(str[i]))
    {
        digits += str[i];
    }
    else if(char.IsLetter(str[i]))
    {
        letters += str[i];
    }
    else// if (char.IsSymbol(str[i]))
    {
        others += str[i];
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(others);