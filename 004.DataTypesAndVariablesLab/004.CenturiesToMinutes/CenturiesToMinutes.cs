//Data types and variables - lab, Task 004
//01.02.2024, 20:38

int centuries = int.Parse(Console.ReadLine());

int years = centuries * 100;
int days = (int)(years * 365.2422M);
int hours = days * 24;
int minutes = hours * 60;

Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");