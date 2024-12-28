

using _06.Workers;

//TwoLists();

//OneList();

static void TwoLists()
{
    var hourlyWorkers = new List<HourlyWorker>();
    var salariedWorkers = new List<SalariedWorker>();
    string input = "";
    while (input != "finish")
    {
        input = Console.ReadLine().ToLower();
        if (input == "finish")
        {
            break;
        }

        string[] lineToken = input.Split();
        string name = lineToken[0];
        decimal payPerHours = decimal.Parse(lineToken[1]);
        string workType = lineToken[2];
        byte hours = byte.Parse(lineToken[3]);

        if (payPerHours == 40)
        {
            salariedWorkers.Add(new SalariedWorker(name, payPerHours, workType));
        }
        else
        {
            var hourlyWorker = new HourlyWorker(name, payPerHours, workType);
            hourlyWorker.Salary(hours);
            hourlyWorkers.Add(hourlyWorker);
        }
    }

    Console.WriteLine("Почасовите работници: ");
    foreach (HourlyWorker worker in hourlyWorkers)
    {
        Console.WriteLine($"Worker: {worker.Name}; Pay per hour: {worker.PayPerHour}; Type of work: {worker.WorkType}; Salary: {worker.HSalary:F2}");
    }
    Console.WriteLine();

    Console.WriteLine("Щатните работници: ");
    foreach (SalariedWorker worker in salariedWorkers)
    {
        Console.WriteLine($"Worker: {worker.Name}; Pay per hour: {worker.PayPerHour}; Type of work: {worker.WorkType}; Salary: {worker.Salary():f2}");
    }
}

static void OneList()
{
    var workers = new List<Worker>();
    string input = "";
    while (input != "finish")
    {
        input = Console.ReadLine().ToLower();
        if (input == "finish")
        {
            break;
        }

        string[] lineToken = input.Split();
        string name = lineToken[0];
        decimal payPerHours = decimal.Parse(lineToken[1]);
        string workType = lineToken[2];
        byte hours = byte.Parse(lineToken[3]);

        if (payPerHours == 40)
        {
            workers.Add(new SalariedWorker(name, payPerHours, workType));
        }
        else
        {
            var hourlyWorker = new HourlyWorker(name, payPerHours, workType);
            hourlyWorker.Salary(hours);
            workers.Add(hourlyWorker);
        }
    }

    Console.WriteLine("Почасовите работници: ");
    foreach (HourlyWorker worker in workers)
    {
        Console.WriteLine($"Worker: {worker.Name}; Pay per hour: {worker.PayPerHour}; Type of work: {worker.WorkType}; Salary: {worker.HSalary:F2}");
    }
    Console.WriteLine();
    Console.WriteLine("Щатните работници: ");
    foreach (SalariedWorker worker in workers)
    {
        Console.WriteLine($"Worker: {worker.Name}; Pay per hour: {worker.PayPerHour};" +
            $" Type of work: {worker.WorkType}; Salary: {worker.Salary():f2}");
    }
}