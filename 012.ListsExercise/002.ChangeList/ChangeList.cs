//Lists - exercise, Task 002
//03.06.2023, 18:06
using System;
using System.Collections.Generic;
using System.Linq;

public class ChangeList
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end")
            {
                break;
            }

            string[] tokens = command.Split().ToArray();

            if (tokens[0] == "Delete")
            {
                DeleteElements(numbers, int.Parse(tokens[1]));
            }
            else if (tokens[0] == "Insert")
            {
                InsertElement(numbers, int.Parse(tokens[1]), int.Parse(tokens[2]));
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }

    static void DeleteElements(List<int> list, int element)
    {
        list.RemoveAll(x => x == element);
    }

    static void InsertElement(List<int> list, int element, int index)
    {
        list.Insert(index, element);
    }
}