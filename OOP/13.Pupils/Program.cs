

using _13.Pupils;

byte numOfPeople = byte.Parse(Console.ReadLine());
Pupil[] pupils = new Pupil[numOfPeople];

for (int i = 0; i < numOfPeople; i++)
{
    string name=Console.ReadLine();
    double[] grades =Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
    pupils[i]=new Pupil(name, grades);
}

foreach (Pupil p in pupils)
{
    Console.WriteLine(p.ToString());
}
