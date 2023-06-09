﻿//Data types and variables - more exercise, Task 006
//28.03.2023, 22:38
using System;

public class BalancedBrackets
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long openCount = 0;
        long closeCount = 0;

        for (int i = 1; i <= n; i++)
        {
            string input = Console.ReadLine();
            if (input == "(")
            {
                openCount++;

            }
            else if (input == ")")
            {
                closeCount++;
                if (openCount - closeCount != 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
        }
        if (openCount == closeCount)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}