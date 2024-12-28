
using _02.Pacient;

//1.Create instance and print info
CreateInstanceAndPrintInfo();

//2.List of patients
ListOfPatients();

//3.Create class Hospital
CreateClassHospitalWithMenu();

static void CreateInstanceAndPrintInfo()
{
    string name = "Georgi Aleksandrov";
    byte age = 19;
    string diagnose = "Grip";
    Patient pacient = new Patient(name, age, diagnose);
    Console.WriteLine(pacient.ToString());
}

static void ListOfPatients()
{
    List<Patient> patients = new List<Patient>();

    string input = "";
    while (input != "Final")
    {
        input = Console.ReadLine();
        if (input == "Final")
        {
            break;
        }

        string[] lineToken = input.Split(";");
        string patientName = lineToken[0];
        byte patientAge = byte.Parse(lineToken[1]);
        string patientDiagnose = lineToken[2];
        patients.Add(new Patient(patientName, patientAge, patientDiagnose));
    }

    foreach (var patient in patients)
    {
        Console.WriteLine(patient.ToString());
    }
}

static void CreateClassHospitalWithMenu()
{
    string hospitalName = "Sveta Nedelq";
    Hospital hospital = new Hospital(hospitalName);

    Console.WriteLine("MENU");
    Console.WriteLine("Add patient in format: Add <name> <age> <diagnose>");
    Console.WriteLine("Find patient by name in format: FindName <name>");
    Console.WriteLine("Find patients by diagnose in format: FindDiagnose <diagnose>");
    Console.WriteLine("Find patient by age diapason in format: FindAge <minAge> <maxAge>");
    Console.WriteLine("Print: Prints information about patients");
    Console.WriteLine("Stop: Stops the program");

    string input = "";
    while (input != "Stop")
    {
        input = Console.ReadLine()!;
        if (input == "Stop")
        {
            break;
        }

        string[] lineToken = input.Split();
        string command = lineToken[0];

        if (command == "Add")
        {
            string name = lineToken[1];
            byte age = byte.Parse(lineToken[2]);
            string diagnose = lineToken[3];
            hospital.AddPatient(new Patient(name, age, diagnose));
        }
        else if (command == "FindName")
        {
            string name = lineToken[1];
            Patient patient = hospital.FindPatientByName(name);
            Console.WriteLine(patient.ToString());
        }
        else if (command == "FindDiagnose")
        {
            string diagnose = lineToken[1];
            List<Patient> patients = hospital.FindPatientsByDiagnose(diagnose);

            foreach (Patient patient in patients) 
            {
                Console.WriteLine(patient.ToString());
            }
        }
        else if (command == "FindAge")
        {
            byte minAge = byte.Parse(lineToken[1]);
            byte maxAge = byte.Parse(lineToken[2]);
            Patient patient = hospital.FindPatientByDiapason(minAge, maxAge);
            Console.WriteLine(patient.ToString());
        }
        else if (command == "Print")
        {
            Console.WriteLine(hospital.ToString());
        }
        else
        {
            Console.WriteLine("Invalid command!");
        }
    }
}