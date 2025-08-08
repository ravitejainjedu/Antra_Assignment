using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class UniversityService: IStudentService, IInstructorService, ICourseService, IDepartmentService
    {
        public int GetAge(Person p) => p.GetAge();
        public decimal GetSalary(Person p) => p.CalculateSalary();
        public IReadOnlyList<Address> GetAddresses(Person p) => p.GetAddresses();

        public double CalculateGPA(Student s) => s.CalculateGPA();
        public void Enroll(Student s, Course c, char grade) => s.Enroll(c, grade);

        public void AssignDepartment(Instructor i, Department d) => i.AssignDepartment(d);

        public void EnrollStudent(Course c, Student s, char grade) => s.Enroll(c, grade);
        public IReadOnlyList<Student> ListStudents(Course c) => c.GetEnrolledStudents();

        public void SetHead(Department d, Instructor i) => d.SetHead(i);
        public void SetBudget(Department d, decimal amount, DateTime from, DateTime to) => d.SetBudget(amount, from, to);
        public IReadOnlyList<Course> ListCourses(Department d) => d.GetCourses();

    }
}
