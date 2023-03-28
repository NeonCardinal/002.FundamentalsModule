//Basic syntax, conditional statements and loop - exercise, Task 002
//24:03.2023, 19:21
using System;

public class Division
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int maxDev = 0;
        bool isDiv = true;

        if(number % 2 == 0)
        {
            maxDev = 2;
        }
        if(number % 3 == 0)
        {
            maxDev = 3;
        }
        if(number % 6 == 0)
        {
            maxDev = 6;
        }
        if(number % 7 == 0)
        {
            maxDev = 7;
        }
        if(number % 10 == 0)
        {
            maxDev = 10;
        }


        if(number % 2 != 0 && number % 3 != 0 && number % 6 != 0 && number % 7 != 0 && number % 10 != 0)
        {
            isDiv = false;
        }

        if(isDiv)
        {
            Console.WriteLine($"The number is divisible by {maxDev}");
        }
        else
        {
            Console.WriteLine("Not divisible");
        }
    }
}