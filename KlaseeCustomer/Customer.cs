using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseeCustomer
{
    /// <summary>
    /// Repräsentiert einen Kunden mit Name, E-Mail und ID.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Statische Variable zur Vergabe einer eindeutigen Kundennummer.
        /// </summary>
        private static int _nextId = 1;

        /// <summary>
        /// Eindeutige Kundennummer.
        /// </summary>
        private int customerId;

        /// <summary>
        /// Vorname des Kunden.
        /// </summary>
        private string firstName;

        /// <summary>
        /// Nachname des Kunden.
        /// </summary>
        private string lastName;

        /// <summary>
        /// E-Mail-Adresse des Kunden.
        /// </summary>
        private string email;

        /// <summary>
        /// Minimale Länge für Vor- und Nachnamen.
        /// </summary>
        public const int MinNameLength = 2;

        /// <summary>
        /// Gibt die Kundennummer zurück.
        /// </summary>
        public int CustomerID => customerId;

        /// <summary>
        /// Vorname des Kunden. Muss mindestens 2 Zeichen lang sein.
        /// </summary>
        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < MinNameLength)
                    Console.WriteLine("Vorname muss mindestens 2 Zeichen lang sein.");
                firstName = value;
            }
        }

        /// <summary>
        /// Nachname des Kunden. Muss mindestens 2 Zeichen lang sein.
        /// </summary>
        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < MinNameLength)
                    Console.WriteLine("Nachname muss mindestens 2 Zeichen lang sein.");
                lastName = value;
            }
        }

        /// <summary>
        /// E-Mail-Adresse des Kunden. Muss gültig sein.
        /// </summary>
        public string Email
        {
            get => email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) && !IsValidEmail(value))
                    Console.WriteLine("Keine valide Email.");
                email = value;
            }
        }

        /// <summary>
        /// Erstellt einen neuen Kunden mit Standardwerten.
        /// </summary>
        public Customer() : this("Max", "Mustermann", null) { }

        /// <summary>
        /// Erstellt einen neuen Kunden mit Vor- und Nachnamen.
        /// </summary>
        /// <param name="firstName">Vorname</param>
        /// <param name="lastName">Nachname</param>
        public Customer(string firstName, string lastName) : this(firstName, lastName, null) { }

        /// <summary>
        /// Erstellt einen neuen Kunden mit Vorname, Nachname und E-Mail.
        /// </summary>
        /// <param name="firstName">Vorname</param>
        /// <param name="lastName">Nachname</param>
        /// <param name="email">E-Mail-Adresse</param>
        public Customer(string firstName, string lastName, string email)
        {
            customerId = _nextId++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        /// <summary>
        /// Gibt den vollständigen Namen des Kunden zurück.
        /// </summary>
        /// <returns>Vorname und Nachname als String</returns>
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        /// <summary>
        /// Aktualisiert die E-Mail-Adresse des Kunden.
        /// </summary>
        /// <param name="newEmail">Neue E-Mail-Adresse</param>
        public void UpdateEmail(string newEmail)
        {
            Email = newEmail;
        }

        /// <summary>
        /// Gibt alle Kundendaten als String zurück.
        /// </summary>
        /// <returns>Kundendaten als formatierter String</returns>
        public string GetCustomerInfo()
        {
            return $"ID: {CustomerID}, Name: {GetFullName()}, E-Mail: {Email ?? "Keine"}";
        }

        /// <summary>
        /// Prüft, ob eine E-Mail-Adresse gültig ist.
        /// </summary>
        /// <param name="email">Die zu prüfende E-Mail-Adresse</param>
        /// <returns>true, wenn die E-Mail gültig ist, sonst false</returns>
        public static bool IsValidEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email)) return false; // Null- oder Leer-Prüfung

            int atIndex = email.IndexOf('@');
            if (atIndex < 1) return false;

            int dotIndex = email.IndexOf('.', atIndex);
            if (dotIndex < atIndex + 2) return false;

            return true;
        }

    }
}
