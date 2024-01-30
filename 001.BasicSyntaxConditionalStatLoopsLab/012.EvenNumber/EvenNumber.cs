//Basic syntax, con statements and loops - lab, Task 012
//26.01.2024, 19:19

while(true)
{
    int number = int.Parse(Console.ReadLine());

    if(number % 2 == 0)
    {
        Console.WriteLine($"The number is: {Math.Abs(number)}");
        break;
    }
    else
    {
        Console.WriteLine("Please write an even number.");
    }
}