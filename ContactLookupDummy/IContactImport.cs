using System.Collections.Generic;

namespace ContactLookupDummy
{
    interface IContactImport
    {
        ICollection<Contact> ImportContacts(string fileName = "Contacts");
    }
}