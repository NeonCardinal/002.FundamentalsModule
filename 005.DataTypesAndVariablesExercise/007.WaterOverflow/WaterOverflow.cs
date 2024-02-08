//Data types and variables - exercise, Task 007
//04.02.2024, 14:13

int n = int.Parse(Console.ReadLine());

int sum = 0;
int capacity = 255;

for(int i = 0; i < n; i++)
{
    int litters = int.Parse(Console.ReadLine());

    if(litters > capacity)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        capacity -= litters;
        sum += litters;
    }
}

Console.WriteLine(sum);