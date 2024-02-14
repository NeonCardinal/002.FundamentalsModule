//Methods - lab, Task 003
//11.02.2024, 21:52

string cmd = Console.ReadLine().ToLower();
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

if(cmd == "add")
{
    Add(firstNumber, secondNumber);
}
else if(cmd == "multiply")
{
    Multiply(firstNumber, secondNumber);
}
else if(cmd == "subtract")
{
    Subtract(firstNumber, secondNumber);
}
else if(cmd == "divide")
{
    Divide(firstNumber, secondNumber);
}

void Divide(int firstNumber, int secondNumber)
{
    Console.WriteLine(firstNumber / secondNumber);
}

void Subtract(int firstNumber, int secondNumber)
{
    Console.WriteLine(firstNumber - secondNumber);
}

void Multiply(int firstNumber, int secondNumber)
{
    Console.WriteLine(firstNumber * secondNumber);
}

void Add(int firstNumber, int secondNumber)
{
    Console.WriteLine(firstNumber + secondNumber);
}