using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertiefsungsarbeit06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new NormalEmployee("Max Muster", 1001, 4000);
            Employee m = new Manager("Anna Beispiel", 1002, 5000, 10000);

            Console.WriteLine($"{e.FullName}, Jahreslohn: {e.GetYearlySalary()}");
            Console.WriteLine($"{m.FullName}, Jahreslohn: {m.GetYearlySalary()}");

            Console.ReadLine();
        }

    }
}
