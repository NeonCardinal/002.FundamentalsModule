//Methods - lab, Task 007
//12.02.2024, 21:52

string input = Console.ReadLine();
int n = int.Parse(Console.ReadLine());

string result = Repeat(input, n);

Console.WriteLine(result);
//Console.WriteLine(Repeat(input, n));

string Repeat(string input, int n)
{
    string result = "";

    for(int i = 0; i < n; i++)
    {
        result += input;
    }

    return result;
}