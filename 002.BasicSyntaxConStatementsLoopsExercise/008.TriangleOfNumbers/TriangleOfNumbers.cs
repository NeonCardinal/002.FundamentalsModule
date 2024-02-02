//Basic syntax, con statements and loops - exercise, Task 008
//30.01.2024, 21:31

int n = int.Parse(Console.ReadLine());

int number = 1;

for(int i = 0; i < n; i++)
{
    for(int j = 0; j < number; j++)
    {
        Console.Write($"{number} ");
    }

    number++;
    Console.WriteLine();
}