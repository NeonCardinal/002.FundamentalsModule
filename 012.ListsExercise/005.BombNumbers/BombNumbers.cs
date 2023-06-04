//Lists - exerce, Task 005
//03.06.2023, 18:39

using System;
using System.Collections.Generic;
using System.Linq;

public class BombNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        List<int> bomb = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        int bombNumber = bomb[0];
        int bombPower = bomb[1];

        //while(numbers.Contains(bombNumber))
        //{
        //    int bombIndex = numbers.IndexOf(bombNumber);

        //    if(bombIndex == 0)
        //    {
        //        numbers.RemoveRange(bombIndex + bombPower, bombPower);
        //    }
        //    else if(bombIndex - bombPower < 0)
        //    {
        //        numbers.RemoveRange(bombIndex - 1, bombIndex - bombPower);
        //    }
        //    else
        //    {
        //        numbers.RemoveRange(bombIndex - bombPower, bombPower);
        //    }

        //    bombIndex -= bombPower;

        //    if(bombIndex == numbers.Count)
        //    {
        //        numbers.RemoveRange(bombIndex - bombPower, bombPower);
        //    }
        //    else if(bombIndex + bombPower > numbers.Count)
        //    {
        //        numbers.RemoveRange(bombIndex + 1, numbers.Count - 1 - bombIndex);
        //    }
        //    else
        //    {
        //        numbers.RemoveRange(bombIndex + bombPower, bombPower);
        //    }

        //    numbers.RemoveAt(bombIndex);
        //}

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNumber)
            {
                int startIndex = i - bombPower;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                int endIndex = i + bombPower + 1;

                if (endIndex > numbers.Count)
                {
                    endIndex = numbers.Count;
                }

                for (int j = startIndex; j < endIndex; j++)
                {
                    numbers.RemoveAt(startIndex);
                }

                i--;
            }
        }

        Console.WriteLine(numbers.Sum());
    }
}