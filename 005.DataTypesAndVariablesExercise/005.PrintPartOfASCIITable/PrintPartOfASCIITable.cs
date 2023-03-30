//Data types and variables - exercise, Task 005
//26.03.2023, 12:28
using System;

public class PrintPartOfASCIITable
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for(int i = start; i <= end; i++)
        {
            char ch = (char)i;
            Console.Write($"{ch} ");
        }
    }
}