using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public interface IStudentService: IPersonService
    {
        double CalculateGPA(Student s);
        void Enroll(Student s, Course c, char grade);
    }
}
