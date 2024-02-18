//Methods - exercise, Task 008
//17.02.2024, 18:27


int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

decimal result = Factoriel(firstNumber) / Factoriel(secondNumber);

Console.WriteLine($"{result:F2}");

decimal Factoriel(int number)
{
    decimal result = 1.0m;

    for(int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;
}