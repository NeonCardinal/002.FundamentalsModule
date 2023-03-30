//Data types and variables - exercise, Task 010
//26.03.2023, 20:04
using System;

public class PokeMon
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int counter = 0;
        double temp = n;

        while (n >= m)
        {
            counter++;
            n -= m;

            if (temp / 2 == n)
            {
                if (y != 0)
                {
                    n /= y;
                }
            }
        }

        Console.WriteLine(n);
        Console.WriteLine(counter);
    }
}