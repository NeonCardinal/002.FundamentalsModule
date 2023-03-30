//Data types and variables - exercise, Task 001
//26.03.2023, 12:13
using System;

public class IntegerOperations
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());

        int result = firstNumber + secondNumber;
        result /= thirdNumber;
        result *= fourthNumber;

        Console.WriteLine(result);
    }
}