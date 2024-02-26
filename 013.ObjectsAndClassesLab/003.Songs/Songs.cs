//Objects and classes - lab, Task 003
//22.02.2024, 22:01

List<Songs> songsList = new List<Songs>();

int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split("_").ToArray();

    string type = input[0];
    string name = input[1];
    string time = input[2];

    Songs song = new Songs();

    song.TypeList = type;
    song.Name = name;
    song.Time = time;

    songsList.Add(song);
}

string command = Console.ReadLine();

if(command == "all")
{
    foreach(var song in songsList)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach(var song in songsList)
    {
        if(command == song.TypeList)
        {
            Console.WriteLine(song.Name);
        }
    }
}

public class Songs
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}

