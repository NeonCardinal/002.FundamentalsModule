﻿//Methods - exercise, Task 006
//17.02.2024, 18:04

string str = Console.ReadLine();

PrintMiddleChar(str);

void PrintMiddleChar(string str)
{
    if(str.Length % 2 == 0)
    {
        Console.WriteLine(str[str.Length / 2 - 1] + "" + (str[str.Length / 2]));
    }
    else
    {
        Console.WriteLine(str[str.Length / 2]);
    }
}