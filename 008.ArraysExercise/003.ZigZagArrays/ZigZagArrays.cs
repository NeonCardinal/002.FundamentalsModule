//Arrays - exercise, Task 003
//08.02.2024, 19:47

int n = int.Parse(Console.ReadLine());

int[] firstArr = new int[n];
int[] secondArr = new int[n];

for(int i = 1; i <= n; i++)
{
    int[] tokens = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    if(i % 2 != 0)
    {
        firstArr[i - 1] = tokens[0];
        secondArr[i - 1] = tokens[1];
    }
    else
    {
        firstArr[i - 1] = tokens[1];
        secondArr[i - 1] = tokens[0];
    }
}

Console.WriteLine(string.Join(" ", firstArr));
Console.WriteLine(string.Join(" ", secondArr));