
string filePath = "input.txt";

int linesCount = 1;

var lines = new List<string>();

using (StreamReader reader = new StreamReader(filePath))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        lines.Add(line);
    }
}

foreach (var input in lines)
{
    var lineToken = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    var countDict = new Dictionary<double, int>();

    foreach (var numStr in lineToken)
    {
        double number = double.Parse(numStr);
        if (countDict.ContainsKey(number))
        {
            countDict[number]++;
        }
        else
        {
            countDict[number] = 1;
        }
    }

    Console.WriteLine($"Ред {linesCount}");
    foreach (var item in countDict)
    {
        Console.WriteLine($"{item.Key} - {item.Value} пъти.");
    }

    linesCount++;
}

