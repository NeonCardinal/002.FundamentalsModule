//Methods - exercise, Task 003
//08.05.2023, 16:24
using System;

public class CharactersInRange
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());

        PrintChars(first, second);
    }

    static void PrintChars(char first, char second)
    {
        if(second < first)
        {
            char temp = first;
            first = second;
            second = temp;
        }

        for(char ch = (char)(first + 1); ch < second; ch++)
        {
            Console.Write($"{(char)ch} ");
        }
    }
}