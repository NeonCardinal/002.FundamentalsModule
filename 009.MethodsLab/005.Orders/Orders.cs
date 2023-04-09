//Methods - lab, Task 005
//08.04.2023, 17:20
using System;

public class Orders
{
    static void Main()
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        CalulateThePrice(product, quantity);
    }

    static void CalulateThePrice(string product, int quantity)
    {
        double price = 0.00;
        switch(product)
        {
            case "coffee":
                {
                    price = quantity * 1.50;
                    Console.WriteLine($"{price:F2}");
                }
                break;
            case "water":
                {
                    price = quantity * 1.00;
                    Console.WriteLine($"{price:F2}");
                }
                break;
            case "coke":
                {
                    price = quantity * 1.40;
                    Console.WriteLine($"{price:F2}");
                }
                break;
            case "snacks":
                {
                    price = quantity * 2.00;
                    Console.WriteLine($"{price:F2}");
                }
                break;
            default:
                break;
        }
    }
}