using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // Student inherits Person, implements its own GPA logic
    public class Student: Person
    {
        private readonly List<(Course course, char grade)> _enrollments = new();

        public Student(string name, DateTime dob)
            : base(name, dob, 0m) { }

        // enroll in a course with a grade
        public void Enroll(Course course, char grade)
        {
            _enrollments.Add((course, grade));
            course.AddStudent(this);
        }

        // GPA: A=4…F=0
        public double CalculateGPA()
        {
            if (!_enrollments.Any()) return 0.0;
            double total = _enrollments.Sum(e => e.grade switch
            {
                'A' => 4.0,
                'B' => 3.0,
                'C' => 2.0,
                'D' => 1.0,
                'F' => 0.0,
                _ => 0.0
            });
            return total / _enrollments.Count;
        }

        public override decimal CalculateSalary() => 0m; // students don’t earn salary

    }
}
