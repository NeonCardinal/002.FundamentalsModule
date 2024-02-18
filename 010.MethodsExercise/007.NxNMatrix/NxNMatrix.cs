//Methods - exercise, Task 007
//17.02.2024, 18:23

int n = int.Parse(Console.ReadLine());

PrintMatrix(n);

void PrintMatrix(int n)
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write($"{n} ");
        }

        Console.WriteLine();
    }
}