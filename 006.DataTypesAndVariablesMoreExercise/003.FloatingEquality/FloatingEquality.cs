//Data types and variables - more exercise, Task 003
//05.02.2024, 20:41

const double Eps = 0.000001;
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double result = Math.Abs(a - b);

if (result > Eps)
{
    Console.WriteLine("False");
}
else if (result < Eps)
{
    Console.WriteLine("True");
}
else if (result == Eps)
{
    Console.WriteLine("False");
}