//Text processing - exercise, Task 004
//11.03.2024, 22:20

using System.Text;

string str = Console.ReadLine();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < str.Length; i++)
{
    sb.Append((char)((int)str[i] + 3));
}

Console.WriteLine(sb.ToString());