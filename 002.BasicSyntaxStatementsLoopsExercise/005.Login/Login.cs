//Basic syntax, conditional statements and loops - exercise, Task 005
//25.03.2023, 11:04
using System;

public class Login
{
    static void Main()
    {
        string username = Console.ReadLine();
        string pass = string.Empty;

        int cnt = 0;

        for (int i = username.Length - 1; i >= 0; i--)
        {
            pass += username[i];
        }

        while (true)
        {
            string password = Console.ReadLine();

            if (password == pass)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
                cnt++;
            }

            if (cnt >= 3)
            {
                Console.WriteLine($"User {username} blocked!");
                break;
            }
        }
    }
}