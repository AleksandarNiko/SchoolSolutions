
string filePath = "result.txt";
var threeDigitNumbers = new List<int>();
for (int i = 100; i <= 999; i++)
{
    var digits = i.ToString().Select(c => c - '0').ToArray();
    if ((digits[0] == digits[1] && digits[0] != digits[2]) ||
        (digits[0] == digits[2] && digits[0] != digits[1]) ||
        (digits[1] == digits[2] && digits[1] != digits[0]))
    {
        threeDigitNumbers.Add(i);
    }
}
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("Трицифрени числа с две равни цифри:");
    foreach (var number in threeDigitNumbers)
    {
        writer.WriteLine(number);
    }
}
Console.WriteLine("Резултатът е записан във файла result.txt");
