//Associative arrays - exercise, Task 007
//02.03.2024, 24:51

var command = string.Empty;
var data = new Dictionary<string, List<string>>();

while ((command = Console.ReadLine()) != "End")
{
    var splittedCommnad = command.Split(" -> ");

    var company = splittedCommnad[0];
    var employeesID = splittedCommnad[1];

    if (data.ContainsKey(company))
    {
        if (!data[company].Contains(employeesID))
        {
            data[company].Add(employeesID);
        }
    }
    else
    {
        data.Add(company, new List<string>());
        data[company].Add(employeesID);
    }
}

foreach (var company in data)
{
    Console.WriteLine(company.Key);
    foreach (var employee in company.Value)
    {
        Console.WriteLine($"-- {employee}");
    }
}