//Objects and classes - exercise, Task 005
//28.02.2024, 13:18

int n = int.Parse(Console.ReadLine());
List<Teams> teamsList = new List<Teams>();

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split("-").ToArray();
    string creator = input[0];
    string teamName = input[1];

    bool isTeamExist = teamsList.Select(x => x.TeamName).Contains(teamName);
    bool isCreatorExist = teamsList.Any(x => x.CreatorName == creator);

    if(!isTeamExist && !isCreatorExist)
    {
        Teams team = new Teams(teamName, creator);

        teamsList.Add(team);

        Console.WriteLine($"Team {teamName} has been created by {creator}!");
    }
    else if(isTeamExist)
    {
        Console.WriteLine($"Team {teamName} was already created!");
    }
    else if(isCreatorExist)
    {
        Console.WriteLine($"{creator} cannot create another team!");
    }
}

while(true)
{
    string input = Console.ReadLine();

    if(input == "end of assignment")
    {
        break;
    }

    string[] tokens = input.Split("->").ToArray();
    string member = tokens[0];
    string team = tokens[1];

    bool isTeamExist = teamsList.Any(x => x.TeamName == team);
    bool isCreatorExist = teamsList.Any(x => x.CreatorName == member);
    bool isAlreadyMember = teamsList.Any(x => x.Members.Contains(member));

    if(isTeamExist && !isCreatorExist && !isAlreadyMember)
    {
        int index = teamsList.FindIndex(x => x.TeamName == team);

        teamsList[index].Members.Add(member);
    }
    else if(!isTeamExist)
    {
        Console.WriteLine($"Team {team} does not exist!");
    }
    else if(isAlreadyMember || isCreatorExist)
    {
        Console.WriteLine($"Member {member} cannot join team {team}!");
    }
}

List<Teams> teamWithMember = teamsList
    .Where(x => x.Members.Count > 0)
    .OrderByDescending(x => x.Members.Count)
    .ThenBy(x => x.TeamName)
    .ToList();
List<Teams> notValidTeam = teamsList
    .Where(x => x.Members.Count == 0)
    .OrderBy(x => x.TeamName)
    .ToList();

foreach (var team in teamWithMember)
{
    Console.WriteLine(team.TeamName);
    Console.WriteLine("- " + team.CreatorName);
    team.Members.Sort();
    Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
}

Console.WriteLine("Teams to disband:");

foreach (var team in notValidTeam)
{
    Console.WriteLine(team.TeamName);
}

public class Teams
{
    public string TeamName { get; set; }
    public string CreatorName { get; set; }
    public List<string> Members { get; set; }

    public Teams(string teamName, string creatorName)
    {
        TeamName = teamName;
        CreatorName = creatorName;
        Members = new List<string>();
    }
}