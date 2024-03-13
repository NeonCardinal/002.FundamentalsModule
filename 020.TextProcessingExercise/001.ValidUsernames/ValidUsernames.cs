//Text Processing - exercise, Task 001
//10.03.2024, 17:40

string[] userName = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
List<string> valid = new List<string>();

for (int i = 0; i < userName.Length; i++)
{
    if (userName[i].Length >= 3 && userName[i].Length <= 16)
    {
        if (IsCorrectSings(userName[i]))
        {
            valid.Add(userName[i]);
        }
    }
}

foreach (var item in valid)
{
    Console.WriteLine(item);
}


static bool IsCorrectSings(string str)
{

foreach (char ch in str)
{
    if (char.IsLetterOrDigit(ch) || ch == '-' || ch == '_')
    {
        continue;
    }
    else
    {
        return false;
    }
}

return true;
}