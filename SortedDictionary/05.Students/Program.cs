
SortedDictionary<byte, List<string>> gradesStudents = new SortedDictionary<byte, List<string>>();
byte count=byte.Parse(Console.ReadLine());
for (int i=0; i<count; i++)
{
    string[] lineToken = Console.ReadLine().Split("-");
    string name=lineToken[0];
    byte grade=byte.Parse(lineToken[1]);

    if (!gradesStudents.ContainsKey(grade))
    {
        gradesStudents[grade] = new List<string>();
    }
    gradesStudents[grade].Add(name);
}

foreach (var item in gradesStudents)
{
    Console.WriteLine($"{item.Key}: {string.Join(",",item.Value)}");
}

/*
5
ivan - 5
mara - 6
george - 5
anna - 4
dimi – 6
*/