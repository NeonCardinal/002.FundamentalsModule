//Methods - lab, Task 008
//12.02.2024, 21:56

double a = double.Parse(Console.ReadLine());
double power = double.Parse(Console.ReadLine());

Console.WriteLine(RisePower(a, power));

double RisePower(double a, double power)
{
    double result = Math.Pow(a, power);

    return result;
}