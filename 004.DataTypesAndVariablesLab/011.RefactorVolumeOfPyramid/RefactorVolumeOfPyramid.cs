//Data types and variables - lab, Task 011
//04.02.2024, 12:06

Console.Write("Length: ");
double lengt = double.Parse(Console.ReadLine());
Console.Write("Width: ");
double width = double.Parse(Console.ReadLine());
Console.Write("Height: ");
double height = double.Parse(Console.ReadLine());
double volume = (lengt * width * height) / 3;
Console.WriteLine($"Pyramid Volume: {volume:f2}");