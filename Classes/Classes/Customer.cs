using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        // Encapsulation
        private string _firstName;
        public string EfirstName  { get { return "Mrs" + _firstName; } set { _firstName = value; } }
    }
}
