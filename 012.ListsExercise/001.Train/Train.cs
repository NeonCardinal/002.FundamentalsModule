//Lists - exercise, Task 001
//03.06.2023, 18:05
using System;
using System.Collections.Generic;
using System.Linq;

public class Train
{
    static void Main()
    {
        List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
        int maxCapacity = int.Parse(Console.ReadLine());

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end")
            {
                break;
            }

            string[] tokens = command.Split();

            if (tokens[0] == "Add")
            {
                train.Add(int.Parse(tokens[1]));
            }
            else
            {
                int pToAdd = int.Parse(tokens[0]);
                AddPassengers(train, maxCapacity, pToAdd);
            }
        }

        Console.WriteLine(string.Join(" ", train));
    }

    static void AddPassengers(List<int> list, int maxCap, int passengers)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int sum = list[i] + passengers;

            if (sum <= maxCap)
            {
                list[i] += passengers;
                break;
            }
        }
    }
}