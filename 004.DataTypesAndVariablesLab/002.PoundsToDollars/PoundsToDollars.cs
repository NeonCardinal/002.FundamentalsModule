//Data types and variables - lab, Task 002
//01.02.2024, 20:24

decimal pounds = decimal.Parse(Console.ReadLine());

decimal dollars = pounds * 1.31m;

Console.WriteLine($"{dollars:F3}");