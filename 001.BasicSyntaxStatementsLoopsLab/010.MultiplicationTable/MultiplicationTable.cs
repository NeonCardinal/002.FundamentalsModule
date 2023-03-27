//Basic syntax, conditional statements and loops - lab, Task 010
//23.03.2023, 08:40
using System;

public class MultiplicationTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} X {i} = {n * i}");
        }
    }
}