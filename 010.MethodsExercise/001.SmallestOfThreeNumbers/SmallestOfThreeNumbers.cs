//Methods - exercise, Task 001
//08.05.2023, 16:10
using System;

public class SmallestOfThreeNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        SmallestNumber(firstNumber, secondNumber, thirdNumber);
    }

    static void SmallestNumber(int first, int second, int third)
    {
        int smallest = Math.Min(first, second);
        smallest = Math.Min(smallest, third);

        Console.WriteLine(smallest);
    }
}