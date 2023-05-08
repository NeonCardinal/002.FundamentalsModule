//Methods - exercise, Task 006
//08.05.2023, 16:57
using System;

public class MiddleCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();

        Middle(text);
    }

    static void Middle(string text)
    {
        if(text.Length % 2 == 0)
        {
            Console.WriteLine(text[text.Length / 2 - 1] + "" + text[text.Length / 2]);
        }
        else
        {
            Console.WriteLine(text[text.Length / 2]);
        }
    }
}