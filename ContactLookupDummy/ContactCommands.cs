using System;
using System.Collections.Generic;
using System.Text;

namespace ContactLookupDummy
{       
    [CommandType("Contact")]
    class ContactCommands
    {
        [Argument("a")]
        public void AddContact(string commandText)
        {
            IContactImport contactImport = new ContactImport();
            List<Contact> contacts = new List<Contact>(contactImport.ImportContacts());
            contacts.Add(new Contact(commandText.Split(",")[0], commandText.Split(",")[1]));
            IContactExport contactExport = new ContactExport();
            contactExport.SetContacts(contacts);
        }
    }
}
