//Methods - exercise, Task 005
//08.05.2023, 16:39
using System;

public class AddAndSubtract
{
    static int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    static void Subtract(int firstNumber, int secondNumber)
    {
        Console.WriteLine(firstNumber - secondNumber);
    }

    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int sum = Add(first, second);

        Subtract(sum, third);
    }
}