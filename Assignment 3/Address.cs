using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // Address holds street info
    public class Address
    {
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }

        public Address(string street, string city, string state, string zip)
        {
            Street = street; City = city; State = state; Zip = zip;
        }
    }
}
