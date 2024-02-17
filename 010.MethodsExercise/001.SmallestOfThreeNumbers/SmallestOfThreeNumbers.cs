//Methods - lab, Task 001
//13.02.2024, 22:33

int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

PrintSmallest(first, second, third);

void PrintSmallest(int a, int b, int c)
{
    int smallest = int.MaxValue;

    if(a < smallest)
    {
        smallest = a;
    }
    if(b < smallest)
    {
        smallest = b;
    }
    if(c < smallest)
    {
        smallest = c;
    }

    Console.WriteLine(smallest);
}