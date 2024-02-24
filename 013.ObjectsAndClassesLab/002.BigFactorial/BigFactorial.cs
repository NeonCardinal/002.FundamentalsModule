//Objects and classes - lab, Task 002
//22.02.2024, 21:57

using System.Numerics;

int n = int.Parse(Console.ReadLine());
BigInteger factoriel = 1;

for(int i = 1; i <= n; i++)
{
    factoriel *= i;
}

Console.WriteLine(factoriel);