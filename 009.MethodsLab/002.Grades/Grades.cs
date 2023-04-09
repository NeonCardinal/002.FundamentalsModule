//Methods - lab, Task 002
//08.04.2023, 12:39
using System;

public class Grades
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());

        Grade(grade);
    }

    /// <summary>
    /// Показва оценката
    /// </summary>
    static void Grade(double grade)
    {
        if(grade >= 2.00 && grade <= 2.99)
        {
            Console.WriteLine("Fail");
        }
        else if(grade >= 3.00 && grade <= 3.49)
        {
            Console.WriteLine("Poor");
        }
        else if(grade >= 3.50 && grade <= 4.49)
        {
            Console.WriteLine("Good");
        }
        else if(grade >= 4.50 && grade <= 5.49)
        {
            Console.WriteLine("Very good");
        }
        else if(grade >= 5.50 && grade <= 6.00)
        {
            Console.WriteLine("Excellent");
        }
    }
}