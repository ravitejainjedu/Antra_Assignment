using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // Person is the abstract base: encapsulates name, DOB, addresses
    public abstract class Person
    {
        private readonly List<Address> _addresses = new();
        public string Name { get; }
        public DateTime BirthDate { get; }
        protected decimal BaseSalary { get; set; }

        protected Person(string name, DateTime birthDate, decimal baseSalary)
        {
            Name = name;
            BirthDate = birthDate;
            BaseSalary = baseSalary < 0 ? throw new ArgumentException("Salary cannot be negative") : baseSalary;
        }

        // calculate age from BirthDate
        public int GetAge() => (int)((DateTime.Today - BirthDate).TotalDays / 365.25);

        // allow adding/getting addresses
        public void AddAddress(Address addr) => _addresses.Add(addr);
        public IReadOnlyList<Address> GetAddresses() => _addresses.AsReadOnly();

        // polymorphic salary calculation
        public abstract decimal CalculateSalary();
    }
}
