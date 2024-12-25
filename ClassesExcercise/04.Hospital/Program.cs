

using _04.Hospital;
using System.Reflection.Metadata;



    string hospitalName = "Света Неделя";
    string city = "София";
    string hospitalAddress = "Бул. Черни Връх 6";
    Hospital hospital = new Hospital(hospitalName, city, hospitalAddress);


    Console.WriteLine("MENU");
    Console.WriteLine();
    Console.WriteLine("ADD – добавяне на пациент във формат: " +
        "ADD,<име на пациента>,<адрес>,<години>,<диагноза>");
    Console.WriteLine("SearchP – търсене по име на пациент във формат: " +
        "Search,<име на търсения пациент>");
    Console.WriteLine("D – търсене по диагноза, извежда списък на пациентите с тази диагноза във формат: " +
        "D,<търсена диагноза>");
    Console.WriteLine("All – извеждане на информация за всички пациенти във формат: " +
        "All<няма информация >");

    while (true)
    {
        string[] lineToken = Console.ReadLine().Split(",");
        string command=lineToken[0];

        if(command == "All")
        {
            foreach (var item in hospital.Patients)
            {
              Console.WriteLine(item.ToString());
            }
        }
        else if(command == "ADD")
        {
          string name=lineToken[1];
          string address=lineToken[2];
          byte age=byte.Parse(lineToken[3]);
          string diagnose = lineToken[4];
          hospital.Patients.Add(new Patient(name,address,age,diagnose));
          Console.WriteLine($"Added patient: {name}");
    }
        else if(command == "Search")
        {
        string name=lineToken[1];
        var patient=hospital.FindPatientByName(name);
        Console.WriteLine($"Found patient by name: {patient.ToString()}");
    }
        else if (command == "D")
    {
        string diagnose=lineToken[1];
        var patient=hospital.FindPatientByDiagnose(diagnose);
        Console.WriteLine($"Found patient by diagnose: {patient.ToString()}");
    }
    else
    {
        continue;
    }

}
