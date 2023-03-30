//Data types and variables - exercise, Task 003
//26.03.2023, 12:22
using System;

public class Elevator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int courses = (int)Math.Ceiling((double)n / p);

        Console.WriteLine(courses);
    }
}