//Basic syntax, conditional statements and loops - lab, Task 006
//22.03.2023, 23:54
using System;

public class ForeignLanguages
{
    static void Main()
    {
        string country = Console.ReadLine();

        switch(country)
        {
            case "England":
            case "USA":
                Console.WriteLine("English");
                break;
            case "Spain":
            case "Argentina":
            case "Mexico":
                Console.WriteLine("Spanish");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}