//Text processing - lab, Task 002
//10.03.2024, 16:22

using System.Text;

string[] input = Console.ReadLine().Split(" ").ToArray();

StringBuilder sb = new StringBuilder();

foreach(var word in input)
{
    for(int i = 0; i < word.Length; i++)
    {
        sb.Append(word);
    }
}

Console.WriteLine(sb.ToString());