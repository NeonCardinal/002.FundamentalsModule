//Methods - exercise, Task 009
//17.02.2024, 18:33

while (true)
{
    string command = Console.ReadLine();

    if (command == "END")
    {
        break;
    }
    else
    {
        Console.WriteLine(IsPalidrome(command));
    }
}

static bool IsPalidrome(string number)
{
    string reversed = "";

    for (int i = number.Length - 1; i >= 0; i--)
    {
        reversed += number[i];
    }

    if (number == reversed)
    {
        return true;
    }
    else
    {
        return false;
    }
}