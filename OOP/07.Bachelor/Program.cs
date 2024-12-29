
using _07.Bachelor;

Bachelor[] bachelors = new Bachelor[2];

for (int i = 0; i < bachelors.Length; i++)
{
    bachelors[i] = new Bachelor()
    {
        Name = Console.ReadLine(),
        Grades = Console.ReadLine().Split(' ').Select(double.Parse).ToArray()
    };
}

foreach (var item in bachelors)
{
    if (item.areValidGrades(item.Grades) == "no")
    {
        continue;
    }
    else
    {

    }
}