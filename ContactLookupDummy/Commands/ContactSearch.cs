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
            ContactImport contactImport = new ContactImport(FileType.json);
            contacts = contactImport.ImportContacts().ToList();
        }

        [Argument("fn")]
        public IEnumerable<Contact> FirstNameSearch(string firstName)
        {
            return contacts.Where(x => x.FirstName == firstName);
        }

        [Argument("ln")]
        public IEnumerable<Contact> LastNameSearch(string lastName)
        {
            return contacts.Where(x => x.LastName == lastName);
        }

    }
}
