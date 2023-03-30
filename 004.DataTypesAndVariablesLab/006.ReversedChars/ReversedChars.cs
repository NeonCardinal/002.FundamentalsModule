//Data types and variables - lab, Task 006
//26.03.2023, 00:19
using System;

public class ReversedChars
{
    static void Main()
    {
        string txt = "";

        for(int i = 0; i < 3; i++)
        {
            char symbol = char.Parse(Console.ReadLine());

            txt += symbol;
        }

        for(int i = txt.Length - 1; i >= 0; i--)
        {
            Console.Write($"{txt[i]} ");
        }
    }
}