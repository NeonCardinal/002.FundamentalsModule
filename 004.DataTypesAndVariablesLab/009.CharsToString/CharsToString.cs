//Data types and variables - lab, Task 009
//26.03.2023, 00:29
using System;

public class CharsToString
{
    static void Main()
    {
        char a = char.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());

        string str = "";
        str += a + "" + b + "" + c;

        Console.WriteLine(str);
    }
}