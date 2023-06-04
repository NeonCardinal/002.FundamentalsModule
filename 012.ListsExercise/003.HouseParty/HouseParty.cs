//Lists - exercise, Task 003
//03.06.2023, 18:12
using System;
using System.Collections.Generic;
using System.Linq;

public class HouseParty
{
    static void Main()
    {
        int numberOfCommands = int.Parse(Console.ReadLine());
        List<string> guestsList = new List<string>();

        for (int i = 0; i < numberOfCommands; i++)
        {
            string command = Console.ReadLine();

            string[] tokens = command.Split().ToArray();

            if (tokens.Length == 3)
            {
                AddPerson(guestsList, tokens[0]);
            }
            else if (tokens.Length == 4)
            {
                RemoverPerson(guestsList, tokens[0]);
            }
        }

        foreach (var name in guestsList)
        {
            Console.WriteLine(name);
        }
    }

    static void AddPerson(List<string> list, string name)
    {
        if (list.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            list.Add(name);
        }
    }

    static void RemoverPerson(List<string> list, string name)
    {
        if (list.Contains(name))
        {
            list.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}