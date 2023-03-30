//Data types and variables - lab, Task 010
//26.03.2023, 00:33
using System;

public class LowerOrUpper
{
    static void Main()
    {
        char ch = char.Parse(Console.ReadLine());

        if(char.IsUpper(ch))
        {
            Console.WriteLine("upper-case");
        }
        else
        {
            Console.WriteLine("lower-case");
        }
    }
}