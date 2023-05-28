//Lists - lab, Task 006
//28.05.2023, 16:44
using System;
using System.Collections.Generic;
using System.Linq;

public class ListManipulationBasics
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while(true)
        {
            string command = Console.ReadLine();

            if(command == "end")
            {
                Console.WriteLine(String.Join(" ", numbers));
                break;
            }

            string[] tokens = command.Split();
            string cmd = tokens[0];

            if(cmd == "Add")
            {
                int number = int.Parse(tokens[1]);
                numbers.Add(number);
            }
            else if(cmd == "Remove")
            {
                int number = int.Parse(tokens[1]);
                numbers.Remove(number);
            }
            else if(cmd == "RemoveAt")
            {
                int index = int.Parse(tokens[1]);
                numbers.RemoveAt(index);
            }
            else if(cmd == "Insert")
            {
                int number = int.Parse(tokens[1]);
                int index = int.Parse(tokens[2]);
                numbers.Insert(index, number);

            }
        }
    }
}