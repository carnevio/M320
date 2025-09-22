    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertiefsungsarbeit06
{
    internal class Manager : Employee
    {
        private double bonus;

        public Manager(string fullName, int employeeNumber, double monthlySalary, double bonus)
            : base(fullName, employeeNumber, monthlySalary) 
        {
            this.bonus = bonus;
        }


        public new double GetYearlySalary()
        {
            double baseSalary = base.GetYearlySalary();
            return baseSalary + bonus;
        }
    }
}
