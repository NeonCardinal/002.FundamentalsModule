//Basic syntax, conditional statements and loops - more exercise, Task 004
//25.03.2023, 11:32
using System;

public class ReverseString
{
    static void Main()
    {
        string txt = Console.ReadLine();

        string rev = string.Empty;

        for (int i = txt.Length - 1; i >= 0; i--)
        {
            rev += txt[i];
        }

        Console.WriteLine(rev);
    }
}