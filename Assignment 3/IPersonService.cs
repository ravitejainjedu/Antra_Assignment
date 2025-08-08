using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // service interfaces
    public interface IPersonService
    {
        int GetAge(Person p);
        decimal GetSalary(Person p);
        IReadOnlyList<Address> GetAddresses(Person p);
    }
}
