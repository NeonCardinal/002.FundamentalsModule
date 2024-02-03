//Basic syntax, con statements and loops - more exercise, Task 004
//31.01.2024, 00:03

string str = Console.ReadLine();
string reversed = string.Empty;

for(int i = str.Length - 1; i >= 0; i--)
{
    reversed += str[i];
}

Console.WriteLine(reversed);