//Basic syntax, conditional statements and loops - more exercise, Task 002
//25.03.2023, 11:28
using System;

public class EnglishNameOfTheLastDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(DigitToTxt(number));
    }

    static string DigitToTxt(int number)
    {
        int n = number % 10;
        string txt = string.Empty;

        switch (n)
        {
            case 0:
                txt = "zero";
                break;
            case 1:
                txt = "one";
                break;
            case 2:
                txt = "two";
                break;
            case 3:
                txt = "three";
                break;
            case 4:
                txt = "four";
                break;
            case 5:
                txt = "five";
                break;
            case 6:
                txt = "six";
                break;
            case 7:
                txt = "seven";
                break;
            case 8:
                txt = "eight";
                break;
            case 9:
                txt = "nine";
                break;
            default:
                break;
        }

        return txt;
    }
}