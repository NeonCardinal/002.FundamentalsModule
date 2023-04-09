//Methods - lab, Task 006
//08.04.2023, 18:29
using System;

public class CalculateRectangleArea
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = CalculateArea(width, height);

        Console.WriteLine(area);
    }

    static double CalculateArea(double width, double height)
    {
        return width * height;
    }
}