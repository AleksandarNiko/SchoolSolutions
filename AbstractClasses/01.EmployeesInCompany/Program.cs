

using _01.EmployeesInCompany;

HashSet<BaseEmployee> employees = new HashSet<BaseEmployee>();

string input = "";
while (input != "stop")
{
    input = Console.ReadLine();
    if (input == "stop")
    {
        break;
    }
    string[] lineToken = input.Split();

    string id = lineToken[0];
    string name = lineToken[1];
    string address = lineToken[2];
    string position = lineToken[3];
    string department = lineToken[4];
    int workingHours = int.Parse(lineToken[5]);

    FullTimeEmployee employee = new FullTimeEmployee(id, name, address, position, department);
    employee.Salary = employee.CalculateSalary(workingHours);

    employees.Add(employee);
}