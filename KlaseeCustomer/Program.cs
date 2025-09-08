using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseeCustomer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Customer Testprogramm ===\n");

            // Kunde mit Standardwerten
            Customer c1 = new Customer();
            Console.WriteLine("Kunde 1 (Standard):");
            Console.WriteLine(c1.GetCustomerInfo());
            Console.WriteLine();

            // Kunde mit Vorname + Nachname
            Customer c2 = new Customer("Anna", "Müller");
            Console.WriteLine("Kunde 2:");
            Console.WriteLine(c2.GetCustomerInfo());
            Console.WriteLine();

            // Kunde mit Vorname + Nachname + Email
            Customer c3 = new Customer("Peter", "Schmidt", "peter.schmidt@example.com");
            Console.WriteLine("Kunde 3:");
            Console.WriteLine(c3.GetCustomerInfo());
            Console.WriteLine();

            // Email-Update
            Console.WriteLine("E-Mail von Kunde 2 aktualisieren...");
            c2.UpdateEmail("anna.mueller@testmail.de");
            Console.WriteLine(c2.GetCustomerInfo());
            Console.WriteLine();

            // Vollständiger Name
            Console.WriteLine("Vollständiger Name von Kunde 3:");
            Console.WriteLine(c3.GetFullName());
            Console.WriteLine();

            Console.WriteLine("=== Test abgeschlossen ===");
            Console.ReadLine(); // damit das Fenster offen bleibt
        }
    
    }
}
