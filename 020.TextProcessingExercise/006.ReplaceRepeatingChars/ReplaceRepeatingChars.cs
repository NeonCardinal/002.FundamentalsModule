//Text processing - exercise, Task 006
//11.03.2024, 22:23

var str = Console.ReadLine().ToList(); ;
string result = string.Empty;

for (int i = 0; i < str.Count - 1; i++)
{
    if (str[i] == str[i + 1])
    {
        str.RemoveAt(i);
        i--;
    }
}

Console.WriteLine(string.Join("", str));