//Methods - lab, Task 009
//08.04.2023, 18:37
using System;

public class GreaterOfTwoValues
{
    static void Main()
    {
        string type = Console.ReadLine().ToLower();

        if (type == "int")
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, b));
        }
        else if (type == "char")
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, b));
        }
        else if (type == "string")
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            Console.WriteLine(GetMax(first, second));
        }
    }

    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }

    static char GetMax(char a, char b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static string GetMax(string firstString, string secondString)
    {
        if ((firstString.CompareTo(secondString)) >= 0)
        {
            return firstString;
        }
        else
        {
            return secondString;
        }
    }
}