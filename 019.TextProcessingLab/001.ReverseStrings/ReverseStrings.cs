//Text processing - lab, Task 001
//04.02.2024, 20:54

while(true)
{
    string input = Console.ReadLine();

    if(input == "end")
    {
        break;
    }

    string reversed = "";

    for(int i = input.Length - 1; i >= 0; i--)
    {

        reversed += input[i];
    }

    Console.WriteLine($"{input} = {reversed}");
}