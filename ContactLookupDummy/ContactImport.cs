using System.Collections.Generic;

namespace ContactLookupDummy
{
    class ContactImport : JsonImport<ICollection<Contact>>, IContactImport
    {
        public ICollection<Contact> ImportContacts(string fileName = "contacts")
        {
            return JsonSave(fileName);
        }
    }
}
