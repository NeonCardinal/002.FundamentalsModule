//Text processing - exercise, Task 007
//11.03.2024, 22:25

using System.Text;

string str = Console.ReadLine();
StringBuilder sb = new StringBuilder();
int bombPower = 0;

for (int i = 0; i < str.Length; i++)
{
    char currCh = str[i];

    if (currCh == '>')
    {
        int currBombPower = GetInt(str[i + 1]);
        sb.Append(currCh);
        bombPower += currBombPower;
    }
    else
    {
        if (bombPower > 0)
        {
            bombPower--;
        }
        else
        {
            sb.Append(currCh);
        }
    }
}

Console.WriteLine(sb.ToString());

    static int GetInt(char ch)
{
    return (int)ch - 48;
}