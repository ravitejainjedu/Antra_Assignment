using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // Instructor inherits Person, adds department and bonus by experience
    public class Instructor:Person
    {
        public DateTime JoinDate { get; }
        public Department Department { get; private set; }

        public Instructor(string name, DateTime dob, decimal baseSalary, DateTime joinDate)
            : base(name, dob, baseSalary)
        {
            JoinDate = joinDate;
        }

        public void AssignDepartment(Department dept)
        {
            Department = dept;
        }

        // salary = base + \$1000 per year of experience
        public override decimal CalculateSalary()
        {
            int years = (int)((DateTime.Today - JoinDate).TotalDays / 365.25);
            return BaseSalary + years * 1000m;
        }
    }
}
