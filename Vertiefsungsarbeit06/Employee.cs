using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertiefsungsarbeit06
{
    public abstract class Employee
    {
        private string FullName { get; set; }
        private int EmployeeNumber { get; set; }
        private double MonthlySalary { get; set; }

        public virtual double GetYearlySalary()
        {
            return MonthlySalary * 12;
        }

        public Employee(string fullName, int employeeNumber, double monthlySalary)
        {
            FullName = fullName;
            EmployeeNumber = employeeNumber;
            MonthlySalary = monthlySalary;
        }

        
    }
}
