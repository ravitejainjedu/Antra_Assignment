using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public interface IDepartmentService
    {
        void SetHead(Department d, Instructor i);
        void SetBudget(Department d, decimal amount, DateTime from, DateTime to);
        IReadOnlyList<Course> ListCourses(Department d);
    }
}
