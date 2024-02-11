//Arrays - lab, Task 001
//07.02.2024, 18:34

string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

int day = int.Parse(Console.ReadLine());

if(day >= 1 && day <= days.Length)
{
    Console.WriteLine(days[day - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}