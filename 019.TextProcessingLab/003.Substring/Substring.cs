//Text processing - lab, Task 003
//10.03.2024, 16:29

string word = Console.ReadLine();
string str = Console.ReadLine();

while(str.IndexOf(word) != -1)
{
    int index = str.IndexOf(word);
    str = str.Remove(index, word.Length);
}

Console.WriteLine(str);