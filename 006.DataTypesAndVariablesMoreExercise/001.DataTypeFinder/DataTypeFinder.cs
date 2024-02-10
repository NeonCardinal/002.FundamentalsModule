//Data types and variables - more exercise, Task 001
//05.02.2024, 20:21

while (true)
{
    string command = Console.ReadLine();

    bool isBool;
    char ch;
    int number;
    double floatingPoingNumber;

    if(command == "END")
    {
        break;
    }

    if (bool.TryParse(command, out isBool))
    {
        Console.WriteLine($"{command} is boolean type");
    }
    else if (int.TryParse(command, out number))
    {
        Console.WriteLine($"{command} is integer type");
    }
    else if (char.TryParse(command, out ch))
    {
        Console.WriteLine($"{command} is character type");
    }
    else if (double.TryParse(command, out floatingPoingNumber))
    {
        Console.WriteLine($"{command} is floating point type");
    }
    else
    {
        Console.WriteLine($"{command} is string type");
    }
}