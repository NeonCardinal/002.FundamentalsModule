//Data types and variables - exercise, Task 007
//26.03.2023, 19:50
using System;

public class WaterOverflow
{
    static void Main()
    {
        int waterTankCapacity = 255;
        int capacity = 0;
        int n = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int litters = Int32.Parse(Console.ReadLine());
            capacity += litters;
            if (capacity > waterTankCapacity)
            {
                Console.WriteLine("Insufficient capacity!");
                capacity -= litters;
            }
            if (i == n - 1)
            {
                Console.WriteLine(capacity);
            }
        }
    }
}