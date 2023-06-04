//Lists - exercise, Task 007
//03.06.2023, 18:46
using System;
using System.Collections.Generic;
using System.Linq;

public class AppendArrays
{
    static void Main()
    {
        //string[] text = Console.ReadLine().Split('|');
        //string str = string.Empty;
        //List<string> result = new List<string>();
        //Array.Reverse(text);

        //for(int i = 0; i < text.Length; i++)
        //{
        //    str += text[i];
        //}

        //result = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        //Console.WriteLine(string.Join(" ", result));

        List<string> items = Console.ReadLine().Split('|').ToList();

        items.Reverse();

        List<string> result = new List<string>();

        for (int i = 0; i < items.Count; i++)
        {
            List<string> numbers = items[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int j = 0; j < numbers.Count; j++)
            {
                result.Add(numbers[j]);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
