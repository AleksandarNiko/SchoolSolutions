using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EmployeesInCompany
{
    public abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAddress;

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public virtual void Show() 
        {
            Console.WriteLine($"EmployeeID: {employeeID}; EmployeeName: {employeeName}; EmployeeAddress: {employeeAddress}  ");
        }

        public abstract decimal CalculateSalary(int workingHours);

        public abstract string GetDepartment();


    }
}