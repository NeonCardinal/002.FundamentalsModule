﻿//Data types and variables - lab, Task 005
//26.03.2023, 00:17
using System;

public class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int sum = 0;
            int digits = i;

            while (digits > 0)
            {
                sum += digits % 10;
                digits /= 10;
            }

            if (sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }
        }
    }
}