

using _05.Racers;

//A)
var racers = new List<Racer>();

//Б)
byte numOfRacers = byte.Parse(Console.ReadLine());

//В)
for (byte i = 0; i < numOfRacers; i++)
{
    string[] lineToken = Console.ReadLine().Split(' ');

    string firstName=lineToken[0];
    string lastName=lineToken[1];
    int birthDate=int.Parse(lineToken[2]);
    string startNumber=lineToken[3];
    int pointsFirst=int.Parse(lineToken[4]);
    int pointsSecond=int.Parse(lineToken[5]);
    int pointsThird=int.Parse(lineToken[6]);

    Racer currRacer = new Racer(firstName, lastName, birthDate, startNumber);

    currRacer.Points.Add(pointsFirst);
    currRacer.Points.Add(   pointsSecond);
    currRacer.Points.Add(pointsThird);

    racers.Add(currRacer);
}

var maxRacer = racers.OrderByDescending(x => x.AllScore()).First();
Console.WriteLine($"Finalist: {maxRacer.FirstName} {maxRacer.LastName}.");

List<Racer> juniours = new List<Racer>();
List<Racer> mids= new List<Racer>();
List<Racer> profs= new List<Racer>();
foreach (Racer rac in racers)
{
    if(rac.Grup(2024)== "юноши младша възраст")
    {
        juniours.Add(rac);
    }
    else if(rac.Grup(2024)== "юноши старша възраст")
    {
        mids.Add(rac);
    }
    else if(rac.Grup(2024) == "професионалсти")
    {
        profs.Add(rac);
    }
}

Console.WriteLine("Юноши младша възраст:");
foreach (Racer rac in juniours)
{
    Console.WriteLine($"{rac.FirstName} {rac.LastName} {rac.StartNumber} with {rac.AllScore()} points!");
}

Console.WriteLine("Юноши старша възраст");
foreach (Racer mid in mids)
{
    Console.WriteLine($"{mid.FirstName} {mid.LastName} {mid.StartNumber} with {mid.AllScore()} points!");
}

Console.WriteLine("Професионалсти");
foreach (Racer pro in profs)
{
    Console.WriteLine($"{pro.FirstName} {pro.LastName} {pro.StartNumber} with {pro.AllScore()} points!");
}
