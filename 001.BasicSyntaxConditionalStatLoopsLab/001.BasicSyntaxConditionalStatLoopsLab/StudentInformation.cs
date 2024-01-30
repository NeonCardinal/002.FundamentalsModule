//Basic syntax, con statements and loops - lab, Task 001
//25.01.2024, 00:04

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double grade = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
