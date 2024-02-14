//Methods - lab, Task 002
//10.02.2024, 19:46

double grade = double.Parse(Console.ReadLine());

GradeInWords(grade);

void GradeInWords(double grade)
{
    if(grade >= 2.00 && grade <= 2.99)
    {
        Console.WriteLine("Fail");
    }
    else if(grade >= 3.00 && grade <= 3.49)
    {
        Console.WriteLine("Poor");
    }
    else if(grade >= 3.50 && grade <= 4.49)
    {
        Console.WriteLine("Good");
    }
    else if(grade >= 4.50 && grade <= 5.49)
    {
        Console.WriteLine("Very good");
    }
    else if(grade >= 5.50 && grade <= 6.00)
    {
        Console.WriteLine("Excellent");
    }
}