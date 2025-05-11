
var teams = new SortedDictionary<string, List<string>>();
string input;

while ((input = Console.ReadLine().ToUpper()) != "GOL")
{
    var lineToken = input.Split(new[] { ", " }, StringSplitOptions.None);
    if (lineToken.Length == 2)
    {
        string playerName = lineToken[0];
        string teamName = lineToken[1];

        if (!teams.ContainsKey(teamName))
        {
            teams[teamName] = new List<string>();
        }
        teams[teamName].Add(playerName);
    }
}

foreach (var team in teams)
{
    Console.WriteLine($"{team.Key}: {string.Join(", ", team.Value)}");
}

teams.For
