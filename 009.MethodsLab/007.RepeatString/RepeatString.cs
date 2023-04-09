//Methods - lab, Task 007
//08.04.2023, 18:32
using System;

public class RepeatString
{
    static void Main()
    {
        string text = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Repeat(text, n));
    }

    static string Repeat(string str, int times)
    {
        string result = string.Empty;

        for(int i = 0; i < times; i++)
        {
            result += str;
        }

        return result;
    }
}