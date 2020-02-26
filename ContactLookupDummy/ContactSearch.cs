using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactLookupDummy
{
    class ContactSearch
    {
        public ICollection<Contact> FirstNameSearch(List<Contact> contacts, string firstName)
        {
            return contacts.Where(x => x.FirstName == firstName).ToList();
        }

        public ICollection<Contact> LastNameSearch(List<Contact> contacts, string lastName)
        {
            return contacts.Where(x => x.LastName == lastName).ToList();
        }

    }
}
