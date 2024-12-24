using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EmployeesInCompany
{
    public class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartment;

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress,string employeePosition,string employeeDepartment) 
            : base(employeeID, employeeName, employeeAddress)
        {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }

        public  decimal Salary { get; set; }

        public override decimal CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80M;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"EmployeePosition: {employeePosition}");
            Console.WriteLine($"EmployeeDepartment: {employeeDepartment}");
        }
    }
}
