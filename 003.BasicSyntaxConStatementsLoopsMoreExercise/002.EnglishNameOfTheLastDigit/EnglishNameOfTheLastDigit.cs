//Basic syntax, con statements and loops - more exercise, Task 002
//30.01.2024, 23:38

int n = int.Parse(Console.ReadLine());

Console.WriteLine(LastDigit(n));

static string LastDigit(int n)
{
    string digitToWord = string.Empty;
    int digit = n % 10;

    switch(digit)
    {
        case 0:
            digitToWord = "zero"; break;
        case 1:
            digitToWord = "one"; break;
        case 2:
            digitToWord = "two"; break;
        case 3:
            digitToWord = "three"; break;
        case 4:
            digitToWord = "four"; break;
        case 5:
            digitToWord = "five"; break;
        case 6:
            digitToWord = "six"; break;
        case 7:
            digitToWord = "seven"; break;
        case 8:
            digitToWord = "eight"; break;
        case 9:
            digitToWord = "nine"; break;
        default:
            break;
    }

    return digitToWord;
}