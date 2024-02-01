//Basic syntax, con statements and loops - exercise, Task 003
//27.01.2024, 12:02

int peopleCnt = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine().ToLower();
string day = Console.ReadLine().ToLower();

double price = 0.0;
double discount = 0.0;

if(day == "friday")
{
    if(groupType == "students")
    {
        price = peopleCnt * 8.45;

        if(peopleCnt >= 30)
        {
            discount = 8.45 * 0.15;
            price = peopleCnt * (8.45 - discount);
        }
    }
    else if(groupType == "business")
    {
        price = peopleCnt * 10.90;

        if (peopleCnt >= 100)
        {
            peopleCnt -= 10;
            price = peopleCnt * 10.90;
        }
    }
    else if(groupType == "regular")
    {
        price = peopleCnt * 15.00;

        if(peopleCnt >= 10 && peopleCnt <= 20)
        {
            discount = 15.00 * 0.05;
            price = peopleCnt * (15.00 - discount);
        }
    }
}
else if(day == "saturday")
{
    if (groupType == "students")
    {
        price = peopleCnt * 9.80;

        if (peopleCnt >= 30)
        {
            discount = 9.80 * 0.15;
            price = peopleCnt * (9.80 - discount);
        }
    }
    else if (groupType == "business")
    {
        price = peopleCnt * 15.60;

        if (peopleCnt >= 100)
        {
            peopleCnt -= 10;
            price = peopleCnt * 15.60;
        }
    }
    else if (groupType == "regular")
    {
        price = peopleCnt * 20.00;

        if (peopleCnt >= 10 && peopleCnt <= 20)
        {
            discount = 20.00 * 0.05;
            price = peopleCnt * (20.00 - discount);
        }
    }
}
else if(day == "sunday")
{
    if (groupType == "students")
    {
        price = peopleCnt * 10.46;

        if (peopleCnt >= 30)
        {
            discount = 10.46 * 0.15;
            price = peopleCnt * (10.46 - discount);
        }
    }
    else if (groupType == "business")
    {
        price = peopleCnt * 16.00;

        if (peopleCnt >= 100)
        {
            peopleCnt -= 10;
            price = peopleCnt * 16.00;
        }
    }
    else if (groupType == "regular")
    {
        price = peopleCnt * 22.50;

        if (peopleCnt >= 10 && peopleCnt <= 20)
        {
            discount = 22.50 * 0.05;
            price = peopleCnt * (22.50 - discount);
        }
    }
}

if(price != 0)
{
    Console.WriteLine($"Total price: {price:F2}");
}
