//Basic syntax, conditional statements and loops - lab, Task 002
//22.03.2023, 16:51
using System;

public class Passed
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());

        if(grade >= 3.00)
        {
            Console.WriteLine("Passed!");
        }
    }
}