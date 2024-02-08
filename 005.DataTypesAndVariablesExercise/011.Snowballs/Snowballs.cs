//Data types and variables - exercise, Task 011
//04.02.2024, 22:33

using System.Numerics;

int n = int.Parse(Console.ReadLine());
BigInteger greater = int.MinValue;
int greaterSnow = 0;
int greaterTime = 0;
BigInteger greaterQuality = 0;

for (int i = 0; i < n; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger snowBallValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

    if (snowBallValue >= greater)
    {
        greater = snowBallValue;
        greaterSnow = snowballSnow;
        greaterTime = snowballTime;
        greaterQuality = snowballQuality;
    }
}

Console.WriteLine($"{greaterSnow} : {greaterTime} = {greater} ({greaterQuality})");