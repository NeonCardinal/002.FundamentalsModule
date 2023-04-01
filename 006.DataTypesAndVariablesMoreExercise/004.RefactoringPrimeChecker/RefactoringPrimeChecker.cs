//Data types and variables - more exercise, Task 004
//28.03.2023, 22:35
using System;

public class RefactoringPrimeChecker
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 2; i <= number; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{i} -> true");
            }
            else
            {
                Console.WriteLine($"{i} -> false");
            }

        }
    }
}