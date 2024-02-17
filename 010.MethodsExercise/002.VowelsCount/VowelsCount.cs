//Methods - exercise, Task 002
//13.02.2024, 23:18

string input = Console.ReadLine();

VowelCounter(input);

void VowelCounter(string str)
{
    int cnt = 0;

    for(int i = 0; i < str.Length; i++)
    {
        if (str[i] == 'a' || str[i] == 'e' || str[i] == 'u' || str[i] == 'i' || str[i] == 'o'
            || str[i] == 'A' || str[i] == 'E' || str[i] == 'U' || str[i] == 'I' || str[i] == 'O')
        {
            cnt++;
        }
    }

    Console.WriteLine(cnt);
}