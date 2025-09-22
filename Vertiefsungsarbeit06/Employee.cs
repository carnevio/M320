using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertiefsungsarbeit06
{
    public abstract class Employee
    {
        public string FullName { get; set; }
        public int EmployeeNumber { get; set; }
        public double MonthlySalary { get; set; }

        public Employee(string fullName, int employeeNumber, double monthlySalary)
        {
            FullName = fullName;
            EmployeeNumber = employeeNumber;
            MonthlySalary = monthlySalary;
        }

        public abstract double GetYearlySalary();
    }

}
