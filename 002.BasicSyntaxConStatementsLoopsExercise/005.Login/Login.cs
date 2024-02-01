//Basic syntax, con statements and loops - exercise, Task 005
//27.01.2024, 12:18

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