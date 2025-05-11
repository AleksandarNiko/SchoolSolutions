while (true)
{
    string[] words = Console.ReadLine()
        .Split(" ")
        .Select(x => x.ToLower())
        .ToArray();

    var wordCount = new Dictionary<string, int>();

    foreach (var word in words)
    {
        if (wordCount.ContainsKey(word))
        {
            wordCount[word]++;
        }
        else
        {
            wordCount[word] = 1;
        }
    }

    var oddCountWords = wordCount
        .Where(w => w.Value % 2 != 0)
        .Select(w => w.Key);

    Console.WriteLine(string.Join(" ", oddCountWords));
}

