﻿//Basic syntax, conditional statements and loop - lab, Task 011
//23.03.2023, 08:43
using System;

public class MultiplicationTableVTwo
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int multiplier = int.Parse(Console.ReadLine());

        if (multiplier > 10)
        {
            Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
        }
        else
        {
            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
    }
}