//Lists - lab, Task 005
//28.05.2023, 16:39
using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativesAndReverse
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        numbers.RemoveAll(n => n < 0);

        if(numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}