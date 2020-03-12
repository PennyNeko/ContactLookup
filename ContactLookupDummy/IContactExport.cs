using System.Collections.Generic;

namespace ContactLookupDummy
{
    interface IContactExport
    {
        void SetContacts(ICollection<Contact> contacts, string fileName = "contacts");
    }
}