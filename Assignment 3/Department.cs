using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // Department holds head instructor, budget period, courses
    public class Department
    {
        public string Name { get; }
        public Instructor Head { get; private set; }
        public decimal Budget { get; private set; }
        public DateTime BudgetFrom { get; private set; }
        public DateTime BudgetTo { get; private set; }
        private readonly List<Course> _courses = new();

        public Department(string name) => Name = name;

        public void SetHead(Instructor inst) => Head = inst;
        public void SetBudget(decimal amount, DateTime from, DateTime to)
        {
            Budget = amount; BudgetFrom = from; BudgetTo = to;
        }

        public void AddCourse(Course c) => _courses.Add(c);
        public IReadOnlyList<Course> GetCourses() => _courses.AsReadOnly();
    }
}
