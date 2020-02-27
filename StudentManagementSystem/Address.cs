using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }

        public Address() { }

        public Address(string address1, string address2, string city)
        {
            AddressLine1 = address1;
            AddressLine2 = address2;
            City = city;
        }
    }
}
