﻿//Basic syntax, conditional statements, loops - lab, Task 001
//22.03.2023, 16:47
using System;

public class StudentInformation
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        double grade = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
    }
}