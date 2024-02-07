//Data types and variables - exercise, Task 002
//04.02.2024, 13:53

int number = int.Parse(Console.ReadLine());

int sum = 0;

while(number > 0)
{
    int n = number % 10;
    sum += n;
    number /= 10;
}

Console.WriteLine(sum);