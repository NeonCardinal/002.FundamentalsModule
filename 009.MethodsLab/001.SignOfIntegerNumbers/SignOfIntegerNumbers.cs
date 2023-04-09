//Methods - lab, Task 001
//08.04.2023, 12:34
using System;

public class SignOfIntegerNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        CheckSign(number);
    }
    
    /// <summary>
    /// Проверява за знака на числото
    /// </summary>
    static void CheckSign(int number)
    {
        if(number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if(number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else if(number == 0)
        {
            Console.WriteLine($"The number {number} is zero.");
        }
    }
}