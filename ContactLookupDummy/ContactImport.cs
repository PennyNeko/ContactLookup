using System;
using System.Collections.Generic;
using System.Text;

namespace ContactLookupDummy
{
    class ContactImport : JsonImport<ICollection<Contact>>
    {
        public ICollection<Contact> ImportContacts(string fileName = "Contacts")
        {
            return JsonSave(fileName);
        }
    }
}
