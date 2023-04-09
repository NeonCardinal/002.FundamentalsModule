//Methods - lab, Task 003
//08.04.2023, 13:31
using System;

public class Calculations
{
    static void Main()
    {
        string cmd = Console.ReadLine();
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        if(cmd == "add")
        {
            Add(first, second);
        }
        else if(cmd == "multiply")
        {
            Multiply(first, second);
        }
        else if(cmd == "subtract")
        {
            Subtract(first, second);
        }
        else if(cmd == "divide")
        {
            Divide(first, second);
        }
    }

    /// <summary>
    /// Събира 2 числа
    /// </summary>
    /// <param name="first">Първото число</param>
    /// <param name="second">Второто число</param>
    static void Add(int first, int second)
    {
        Console.WriteLine(first + second);
    }

    /// <summary>
    /// Умножава 2 числа
    /// </summary>
    /// <param name="first">Първото число</param>
    /// <param name="second">Второто число</param>
    static void Multiply(int first, int second)
    {
        Console.WriteLine(first * second);
    }

    /// <summary>
    /// Изважда 2 числа
    /// </summary>
    /// <param name="first">Първото число</param>
    /// <param name="second">Второто число</param>
    static void Subtract(int first, int second)
    {
        Console.WriteLine(first - second);
    }

    /// <summary>
    /// Дели 2 числа
    /// </summary>
    /// <param name="first">Първото число</param>
    /// <param name="second">Второто число</param>
    static void Divide(int first, int second)
    {
        Console.WriteLine(first / second);
    }
}