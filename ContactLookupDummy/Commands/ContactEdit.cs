using System.Collections.Generic;
using System.Linq;

namespace ContactLookupDummy
{
    [CommandType("Edit")]
    class ContactEdit
    {
        ICollection<Contact> contacts = new List<Contact>();
        IContactImport contactImport = new ContactImport();
        IContactExport contactExport = new ContactExport();

        public ContactEdit()
        {
            contacts = contactImport.ImportContacts();
        }

        [Argument("a")]
        public void AddContact(string commandText)
        {
            contacts.Add(new Contact(commandText));
            contactExport.SetContacts(contacts);
        }
    }
}
