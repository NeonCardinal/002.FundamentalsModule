//Data types and variables - exercise, Task 005
//04.02.2024, 14:03

int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for(int i = start; i <= end; i++)
{
    Console.Write($"{(char)i} ");
}