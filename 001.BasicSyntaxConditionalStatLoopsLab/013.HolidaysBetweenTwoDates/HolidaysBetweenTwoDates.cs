//Basic syntax, con statements and loops - lab, Task 013
//26.01.2024, 19:22

using System.Globalization;

var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

var holidaysCount = 0;

for (var date = startDate; date <= endDate; date = date.AddDays(1))
{
    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
    {
        holidaysCount++;
    }
}

Console.WriteLine(holidaysCount);