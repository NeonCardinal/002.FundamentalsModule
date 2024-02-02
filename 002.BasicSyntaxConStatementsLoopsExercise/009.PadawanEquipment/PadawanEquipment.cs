//Basic syntax, con statements and loops - exercise, Task 009
//30.01.2024, 21:35

double johnsMoney = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
double lightsaberPrice = double.Parse(Console.ReadLine());
double robesPrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

int extra = (int)Math.Ceiling(studentsCount * 0.10);
int freeBelt = 0;

for(int i = 1; i <= studentsCount; i++)
{
    if(i % 6 == 0)
    {
        freeBelt++;
    }
}

double beltCost = beltPrice * (studentsCount - freeBelt);
double total = lightsaberPrice * (studentsCount + extra) + robesPrice * studentsCount + beltCost;

if(total <= johnsMoney)
{
    Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
}
else
{
    Console.WriteLine($"John will need {(total - johnsMoney):F2}lv more.");
}