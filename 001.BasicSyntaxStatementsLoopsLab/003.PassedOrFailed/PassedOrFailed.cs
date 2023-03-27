//Basic syntax, conditional statements and loops - lab, Task 003
//22.03.2023, 16:53
using System;

public class PassedOrFailed
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());

        if(grade >= 3.00)
        {
            Console.WriteLine("Passed!");
        }
        else
        {
            Console.WriteLine("Failed!");
        }
    }
}