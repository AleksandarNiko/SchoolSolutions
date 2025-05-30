
var path = "info.txt";
var lines = new List<string>();
using (StreamReader reader = new StreamReader(path))
{
    string line = reader.ReadLine();
    lines.Add(line);
    
    string[] input = line.Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);

    int[] digitCount = new int[10];

    for (int i = a; i <= b; i++)
    {
        string numStr = i.ToString();
       
        foreach (char c in numStr)
        {
            int digit = c - '0';
            digitCount[digit]++;
        }
    }

    int maxCount = -1;
    int digitWithMaxCount = -1;

    for (int i = 0; i < 10; i++)
    {
        if (digitCount[i] > maxCount)
        {
            maxCount = digitCount[i];
            digitWithMaxCount = i;
        }

        else if (digitCount[i] == maxCount && i < digitWithMaxCount)
        {
            digitWithMaxCount = i;
        }
    }

    Console.WriteLine($"{digitWithMaxCount}: Digit {digitWithMaxCount} - {maxCount} times.");
}