//Arrays - exercise, Task 005
//08.02.2024, 20:06

int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

string greater = "";

for (int i = 0; i < arr.Length; i++)
{
    int currentElement = arr[i];
    bool isGreater = true;

    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[j] >= currentElement)
        {
            isGreater = false;
            break;
        }
    }

    if (isGreater)
    {
        greater += currentElement + " ";
    }
}

Console.WriteLine(greater);