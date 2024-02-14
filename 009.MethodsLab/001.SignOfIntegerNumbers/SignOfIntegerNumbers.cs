//Methods - lab, Task 001
//10.02.2024, 19:41

void SignOfNumbers(int number)
{
    if(number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else if(number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }
    else if(number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
}

int number = int.Parse(Console.ReadLine());

SignOfNumbers(number);