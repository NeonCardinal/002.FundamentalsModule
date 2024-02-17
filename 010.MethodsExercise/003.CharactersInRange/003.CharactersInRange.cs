//Methods - exercise, Task 003
//17.02.2024, 17:42

char start = char.Parse(Console.ReadLine());
char end  = char.Parse(Console.ReadLine());

if(end < start)
{
    char temp = start;
    start = end; 
    end = temp;
}

for(int i = start + 1; i < end; i++)
{
    Console.Write($"{(char)i} ");
}