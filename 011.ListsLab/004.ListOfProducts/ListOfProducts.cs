//Lists - lab, Task 004
//28.05.2023, 16:34
using System;
using System.Collections.Generic;

public class ListOfProducts
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> products = new List<string>();

        for(int i = 0; i < n; i++)
        {
            string product = Console.ReadLine();
            products.Add(product);
        }

        products.Sort();

        for(int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{products[i]}");
        }
    }
}