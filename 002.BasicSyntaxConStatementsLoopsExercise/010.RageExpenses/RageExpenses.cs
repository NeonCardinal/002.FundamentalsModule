//Basic syntax, con statements and loops - exercise, Task 010
//30.01.2024, 22:02

int lostGame = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double kbdPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int trashedHeadsetCnt = 0;
int trashedMouseCnt = 0;
int trashedKbdCnt = 0;
int trashedDisplayCnt = 0;

for(int i = 1; i <= lostGame; i++)
{
    if(i % 2 == 0)
    {
        trashedHeadsetCnt++;
    }

    if(i % 3 == 0)
    {
        trashedMouseCnt++;
    }

    if(i % 2 == 0 && i % 3 == 0)
    {
        trashedKbdCnt++;
    }
}

for(int i = 1; i <= trashedKbdCnt; i++)
{
    if(i % 2 == 0)
    {
        trashedDisplayCnt++;
    }
}

double costs = trashedHeadsetCnt * headsetPrice + trashedMouseCnt * mousePrice + trashedKbdCnt * kbdPrice +
    trashedDisplayCnt * displayPrice;

Console.WriteLine($"Rage expenses: {costs:F2} lv.");