//Arrays - exercise, Task 010
//08.02.2024, 21:35

int fieldSIze = int.Parse(Console.ReadLine());
long[] ladybugInit = new long[fieldSIze];
long[] ladybugIndexes = Console.ReadLine().Split().Select(long.Parse).ToArray();

foreach (var index in ladybugIndexes)
{
    if (index >= 0 && index < ladybugInit.Length)
    {
        ladybugInit[index] = 1;
    }
}

string command = Console.ReadLine();

while (command != "end")
{
    string[] tokens = command.Split().ToArray();
    long index = long.Parse(tokens[0]);
    string direction = tokens[1];
    long power = long.Parse(tokens[2]);

    if ((index <= ladybugInit.Length - 1 && index >= 0) && ladybugInit[index] == 1)
    {
        if (direction == "right")
        {
            ladybugInit[index] = 0;
            Right(ladybugInit, index, power);
        }
        else if (direction == "left")
        {
            ladybugInit[index] = 0;
            Left(ladybugInit, index, power);
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(String.Join(" ", ladybugInit));

static void Right(long[] ladybugs, long bugIndex, long flyDir)
{
    for (int i = 0; i < ladybugs.Length; i++)
    {
        if (bugIndex + flyDir + i > ladybugs.Length - 1 || bugIndex + flyDir + i < 0)
        {
            break;
        }

        if (ladybugs[bugIndex + flyDir + i] == 0)
        {
            ladybugs[bugIndex + flyDir + i] = 1;
            break;
        }
    }
}

static void Left(long[] ladybugs, long bugIndex, long flyDir)
{
    for (int i = 0; i < ladybugs.Length; i++)
    {
        if (bugIndex - flyDir - i > ladybugs.Length - 1 || bugIndex - flyDir - i < 0)
        {
            break;
        }

        if (ladybugs[bugIndex - flyDir - i] == 0)
        {
            ladybugs[bugIndex - flyDir - i] = 1;
            break;
        }
    }
}