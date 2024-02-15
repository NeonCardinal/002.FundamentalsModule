//Methods - lab, Task 011
//12.02.2024, 23:05

int a = int.Parse(Console.ReadLine());
string opt = Console.ReadLine();
int b = int.Parse(Console.ReadLine());

Console.WriteLine(Calculate(a, opt, b));

static double Calculate(int a, string opt, int b)
{
    double result = 0.0;

    switch (opt)
    {
        case "+":
            {
                result = a + b;
            }
            break;
        case "-":
            {
                result = a - b;
            }
            break;
        case "*":
            {
                result = a * b;
            }
            break;
        case "/":
            {
                result = a / b;
            }
            break;
        default:
            break;
    }

    return result;
}