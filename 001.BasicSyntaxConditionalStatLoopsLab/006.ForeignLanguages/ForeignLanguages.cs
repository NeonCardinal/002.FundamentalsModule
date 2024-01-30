//Basic syntax, con statements and loop - lab, Task 006
//26.01.2024, 18:37

string country = Console.ReadLine().ToLower();

switch(country)
{
    case "england":
    case "usa":
        Console.WriteLine("English");
        break;
    case "argentina":
    case "mexico":
    case "spain":
        Console.WriteLine("Spanish");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}