using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertiefsungsarbeit06
{
    internal class NormalEmployee : Employee
    {
        public NormalEmployee(string fullName, int employeeNumber, double monthlySalary)
            : base(fullName, employeeNumber, monthlySalary)
        {
        }

        public override double GetYearlySalary()
        {
            return MonthlySalary * 12;
        }
    }
}
