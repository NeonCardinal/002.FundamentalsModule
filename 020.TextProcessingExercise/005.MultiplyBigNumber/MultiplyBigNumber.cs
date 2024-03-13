//Text processing - exercise, Task 005
//11.03.2024, 22:22

string bigNumber = Console.ReadLine();
int number = int.Parse(Console.ReadLine());
List<string> strs = new List<string>();

if (number == 0)
{
    Console.WriteLine(0);
    return;
}

int temp = 0;

for (int i = bigNumber.Length - 1; i >= 0; i--)
{
    temp = int.Parse(Convert.ToString(bigNumber[i])) * number + temp;
    strs.Insert(0, (temp % 10).ToString());
    temp /= 10;
}

if (temp > 0)
{
    Console.WriteLine($"{temp}{string.Join("", strs)}");
}
else
{
    Console.WriteLine(string.Join("", strs));
}