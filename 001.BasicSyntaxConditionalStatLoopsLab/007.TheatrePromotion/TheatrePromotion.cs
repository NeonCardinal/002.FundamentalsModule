//Basic syntax, con statements and loops, Task 007
//26.01.2024, 18:43

string day = Console.ReadLine().ToLower();
int age = int.Parse(Console.ReadLine());

int price = 0;

if(day == "weekday")
{
    if(age >= 0 && age <= 18)
    {
        price = 12;
    }
    else if(age > 18 && age <= 64)
    {
        price = 18;
    }
    else if(price > 64 && age <= 122)
    {
        price = 12;
    }
}
else if(day == "weekend")
{
    if (age >= 0 && age <= 18)
    {
        price = 15;
    }
    else if (age > 18 && age <= 64)
    {
        price = 20;
    }
    else if (age > 64 && age <= 122)
    {
        price = 15;
    }
}
else if(day == "holiday")
{
    if (age >= 0 && age <= 18)
    {
        price = 5;
    }
    else if (age > 18 && age <= 64)
    {
        price = 12;
    }
    else if (age > 64 && age <= 122)
    {
        price = 10;
    }
}

if(price != 0)
{
    Console.WriteLine($"{price}$");
}
else
{
    Console.WriteLine("Error!");
}