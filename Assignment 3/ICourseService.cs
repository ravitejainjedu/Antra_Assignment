﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal interface ICourseService
    {
        void EnrollStudent(Course c, Student s, char grade);
        IReadOnlyList<Student> ListStudents(Course c);

    }
}
