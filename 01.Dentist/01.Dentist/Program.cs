

using _01.Dentist;
using System.Xml.Linq;

Console.WriteLine("Въведи брой пациенти:");
int patientsCount = int.Parse(Console.ReadLine());

Patient[] patients= new Patient[patientsCount];

Console.WriteLine("Въведи информация за всеки пациент във формат: <име>,<дата на раждане>,<брой посещения>,<дали се осигурява на НДОК (true или false)>");
for (int i = 0; i < patientsCount; i++)
{
    string[] lineToken = Console.ReadLine().Split(",");

    string name=lineToken[0];
    string dateOfBirth=lineToken[1];
    int visitings=int.Parse(lineToken[2]);
    bool ndok=bool.Parse(lineToken[3]);

    patients[i]=new Patient(name,dateOfBirth,visitings,ndok);
}
Console.WriteLine();

Console.WriteLine("За да намериш пациенти с определено име, го въведи на следващия ред и натисни Enter:");
string currName=Console.ReadLine();
PrintInfoByName(currName, patients);
Console.WriteLine();

Console.WriteLine("За да намериш пациенти с определен брой посещения или повече, въведи на следващия ред броя и натисни Enter:");
int currVisitings = int.Parse(Console.ReadLine());
PrintNamesByVisitings(currVisitings, patients);
Console.WriteLine();

Console.WriteLine("За да намериш пациенти, които не са здравно осигурени, въведи на следващия ред: да или не; и натисни Enter:");
string check=Console.ReadLine();
if (check == "да")
{
    PrintPatientsWithoutNdok(patients);
}
else 
{
    Console.WriteLine("Стартирай програмата за повторно ползване!");
}

static void PrintInfoByName(string name, Patient[]patients)
{
    Patient patient = null;

    foreach (Patient currPatient in patients)
    {
        if(currPatient.Name == name)
        {
            patient = currPatient;
            break;
        }
    }
    Console.WriteLine("Found patients by name:");
    Console.WriteLine(patient.ToString());
}

static void PrintNamesByVisitings(int visitings, Patient[] patients)
{
    var currPatients= new List<Patient>();

    foreach (Patient currPatient in patients)
    {
        if (currPatient.VisitsCount >= visitings)
        {
            currPatients.Add(currPatient);
        }
    }

    Console.WriteLine("Found patients by visitings:");
    foreach (Patient currPatient in currPatients)
    {
        Console.WriteLine(currPatient.Name);
    }
}

static void PrintPatientsWithoutNdok(Patient[] patients)
{
    var currPatients=new List<Patient>();

    foreach (Patient currPatient in patients) 
    {
        if (currPatient.Ndok == false)
        {
            currPatients.Add(currPatient);
        }
    }

    Console.WriteLine("Found patients by НДОК:");
    foreach (Patient currPatient in currPatients)
    {
        Console.WriteLine(currPatient.Name);
    }
}