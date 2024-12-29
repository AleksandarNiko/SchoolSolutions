
using _04.Angles;

Angle[] angles = new Angle[4];

for (int i = 0; i < 4; i++)
{
    byte angle=byte.Parse(Console.ReadLine()!);
    angles[i] = new Angle(angle)
    {
        AngleSize = angle
    };
}

foreach (Angle angle in angles)
{
    Console.WriteLine(angle.ToString());
}
