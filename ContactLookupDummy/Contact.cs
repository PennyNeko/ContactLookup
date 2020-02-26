using System;
using System.Collections.Generic;
using System.Text;

namespace ContactLookupDummy
{
    class Contact
    {
        public Contact(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { set; get; }
        public string LastName { set; get; }

    }
}
