
Dictionary<int, string> qualities = new Dictionary<int, string>()
{
    { 1, "Independence" },
    { 2, "Diplomacy" },
    { 3, "Natural talent" },
    { 4, "Organizational skills" },
    { 5, "Free spirit" },
    { 6, "Caring and protection" },
    { 7, "Philosophical skills" },
    { 8, "Professionals" },
    { 9, "Tolerance and humanity" },
    { 11, "Visionaries with ideas" },
    { 22, "Confidence and intuition" }
};

List<string> lines = ReadAndPrintOnConsole();

Console.WriteLine();


Dictionary<int, int> numbersCount = new Dictionary<int, int>();

foreach (var line in lines)
{
    int personalNum = CalculatePersonalNumber(line);
    Console.WriteLine($"{line} - лично число: {personalNum} ({qualities[personalNum]})");

    if (numbersCount.ContainsKey(personalNum))
    {
        numbersCount[personalNum]++;
    }
    else
    {
        numbersCount[personalNum] = 1;
    }
}

var mostCommon = numbersCount
    .OrderByDescending(x => x.Value)
    .ThenBy(x => x.Key)
    .First();

Console.WriteLine("\nНай-често срещано лично число:");
Console.WriteLine($"{mostCommon.Key} - {qualities[mostCommon.Key]}");


static int CalculatePersonalNumber(string birthDate)
{
    var parts = birthDate.Split('-');
    int day = int.Parse(parts[0]);
    int month = int.Parse(parts[1]);
    int year = int.Parse(parts[2]);

    int sum = day + month + year;

    while (sum > 9 && sum != 11 && sum != 22)
    {
        sum = sum.ToString().Sum(c => c - '0');
    }

    return sum;
}

static List<string> ReadAndPrintOnConsole()
{
    var path = "info.txt";

    var lines = new List<string>();

    using (StreamReader sr = new StreamReader(path))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            lines.Add(line);
        }
    }

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }

    return lines;
}