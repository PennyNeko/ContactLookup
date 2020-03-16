using System.Collections.Generic;
using System.Linq;

namespace ContactLookupDummy
{
    [CommandType("Search")]
    class ContactSearch
    {
        readonly List<Contact> contacts;
        
        public ContactSearch()
        {
            ContactImport contactImport = new ContactImport();
            contacts = contactImport.ImportContacts().ToList();
        }

        [Argument("fn")]
        public ICollection<Contact> FirstNameSearch(string firstName)
        {
            return contacts.Where(x => x.FirstName == firstName).ToList();
        }

        [Argument("ln")]
        public ICollection<Contact> LastNameSearch(string lastName)
        {
            return contacts.Where(x => x.LastName == lastName).ToList();
        }

    }
}
