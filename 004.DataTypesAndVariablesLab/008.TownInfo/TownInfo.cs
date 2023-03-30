//Data types and variables - lab, Task 008
//26.03.2023, 00:25
using System;

public class TownInfo
{
    static void Main()
    {
        string town = Console.ReadLine();
        long population = long.Parse(Console.ReadLine());
        int area = int.Parse(Console.ReadLine());

        Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
    }
}