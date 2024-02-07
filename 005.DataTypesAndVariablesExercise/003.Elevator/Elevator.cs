//Data types and variables - exercise, Task 003
//04.02.2024, 13:56

int people = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());

int courses = (int)Math.Ceiling((double)people / capacity);

Console.WriteLine(courses);