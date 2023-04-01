//Arrays - lab, Task 001
//28.03.2023, 22:58
using System;

public class DayOfWeek
{
    static void Main()
    {
        string[] days = { "Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday", "Sunday" };

        int day = int.Parse(Console.ReadLine());

        if(day < 1 || day > 7)
        {
            Console.WriteLine("Invalid day!");
        }
        else
        {
            Console.WriteLine($"{days[day - 1]}");
        }
    }
}