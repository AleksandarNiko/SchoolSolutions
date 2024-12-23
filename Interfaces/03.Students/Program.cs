

using _03.Students;



static void CreateOneStudent()
{
    string name = Console.ReadLine();
    List<int> grades = Console.ReadLine().Split().Select(int.Parse).ToList();
    double income = double.Parse(Console.ReadLine());

    Stipendiant stipendiant = new Stipendiant(name, income);
}

static void ReadMultipleStudents()
{
    int n = int.Parse(Console.ReadLine());
    List<Stipendiant> students = new List<Stipendiant>();

    for (int i = 0; i < n; i++)
    {
        string name = Console.ReadLine();
        List<int> grades = Console.ReadLine().Split().Select(int.Parse).ToList();
        double income = double.Parse(Console.ReadLine());

        Stipendiant stipendiant = new Stipendiant(name, income);
        students.Add(stipendiant);
    }

    foreach (Stipendiant student in students)
    {
        Console.WriteLine(student.Info());
    }
}