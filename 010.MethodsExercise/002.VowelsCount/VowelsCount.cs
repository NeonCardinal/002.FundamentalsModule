//Methods - exercise, Task 002
//08.05.2023, 16:15
using System;

public class VowelsCount
{
    static void Main()
    {
        string text = Console.ReadLine();

        VowelsCounter(text);
    }

    static void VowelsCounter(string text)
    {
        int cnt = 0;

        foreach (char item in text)
        {
            if(item == 'a' || item == 'e' || item == 'u' || item == 'i' || item == 'o' ||
                item == 'A' || item == 'E' || item == 'U' || item == 'I' || item == 'O')
            {
                cnt++;
            }
        }

        Console.WriteLine(cnt);
    }
}