﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public interface IInstructorService : IPersonService
    {
        void AssignDepartment(Instructor i, Department d);
    }
}
