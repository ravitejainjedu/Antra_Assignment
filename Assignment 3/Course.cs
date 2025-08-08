using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // Course holds enrolled students
    public class Course
    {
        public string Title { get; }
        private readonly List<Student> _students = new();

        public Course(string title) => Title = title;

        public void AddStudent(Student s)
        {
            if (!_students.Contains(s))
                _students.Add(s);
        }

        public IReadOnlyList<Student> GetEnrolledStudents() => _students.AsReadOnly();
    }
}
