//Methods - lab, Task 006
//12.02.2024, 21:49

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());

double area = GetRectangleArea(a, b);

Console.WriteLine(area);

double GetRectangleArea(double a, double b)
{
    return a * b;
}