//Methods - exercise, Task 005
//17.02.2024, 17:58

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int first = Sum(firstNumber, secondNumber);

Console.WriteLine(Subtract(first, thirdNumber));

int Sum(int a, int b)
{
    return a + b;
}

int Subtract(int a, int b)
{
    return a - b;
}