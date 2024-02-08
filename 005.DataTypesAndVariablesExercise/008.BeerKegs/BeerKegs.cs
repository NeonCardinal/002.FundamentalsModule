//Data types and variables - exercise, Task 008
//04.02.2024, 14:19

int n = int.Parse(Console.ReadLine());

string biggest = string.Empty;
double volume = double.MinValue;

for(int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());

    double newVolume = Math.PI * Math.Pow(radius, 2) * height;

    if(newVolume > volume)
    {
        volume = newVolume;
        biggest = model;
    }
}

Console.WriteLine(biggest);