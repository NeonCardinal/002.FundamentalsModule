//Data types and variables - lab, Task 007
//26.03.2023, 00:23
using System;

public class ConcatNames
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string delimeter = Console.ReadLine();

        string str = firstName + delimeter + lastName;

        Console.WriteLine(str);
    }
}