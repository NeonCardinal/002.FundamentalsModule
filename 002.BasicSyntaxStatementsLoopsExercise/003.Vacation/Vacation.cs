//Basic syntax, conditional statements and loops - exercise, Task 003
//24.03.2023, 19:33
using System;

public class Vacation
{
    static void Main()
    {
        int peopleCnt = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string day = Console.ReadLine();

        double price = 0.00;

        if (groupType == "Students")
        {
            if (day == "Friday")
            {
                price = peopleCnt * 8.45;
            }
            else if (day == "Saturday")
            {
                price = peopleCnt * 9.80;
            }
            else if (day == "Sunday")
            {
                price = peopleCnt * 10.46;
            }

            if (peopleCnt >= 30)
            {
                double discount = price * 0.15;
                price -= discount;
            }
        }
        else if (groupType == "Business")
        {
            if (day == "Friday")
            {
                price = peopleCnt * 10.90;
            }
            else if (day == "Saturday")
            {
                price = peopleCnt * 15.60;
            }
            else if (day == "Sunday")
            {
                price = peopleCnt * 16.00;
            }

            if (peopleCnt >= 100)
            {
                peopleCnt -= 10;

                if (day == "Friday")
                {
                    price = peopleCnt * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = peopleCnt * 15.60;
                }
                else if (day == "Sunday")
                {
                    price = peopleCnt * 16.00;
                }
            }
        }
        else if (groupType == "Regular")
        {
            if (day == "Friday")
            {
                price = peopleCnt * 15.00;
            }
            else if (day == "Saturday")
            {
                price = peopleCnt * 20.00;
            }
            else if (day == "Sunday")
            {
                price = peopleCnt * 22.50;
            }

            if (peopleCnt >= 10 && peopleCnt <= 20)
            {
                double discount = price * 0.05;
                price -= discount;
            }
        }

        Console.WriteLine($"Total price: {price:F2}");
    }
}