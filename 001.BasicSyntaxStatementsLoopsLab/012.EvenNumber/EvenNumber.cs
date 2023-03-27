//Basic syntax, conditional statements and loops - lab, Task 012
//23.03.2023, 08:44
using System;

public class EvenNumber
{
    static void Main()
    {
        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
            }
            else
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");
                break;
            }
        }
    }
}