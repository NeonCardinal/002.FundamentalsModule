//Arrays - exercise, Task 002
//08.02.2024, 19:45

string[] first = Console.ReadLine().Split();
string[] second = Console.ReadLine().Split();
string third = "";

for (int i = 0; i < first.Length; i++)
{
    for (int j = 0; j < second.Length; j++)
    {
        if (second[j] == first[i])
        {
            third += second[j] + " ";
        }
    }
}

Console.WriteLine(third);