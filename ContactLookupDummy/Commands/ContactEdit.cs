using System.Collections.Generic;

namespace ContactLookupDummy
{
    [CommandType("Edit")]
    class ContactEdit
    {
        ICollection<Contact> contacts = new List<Contact>();
        ContactImport contactImport = new ContactImport(FileType.json);
        ContactExport contactExport = new ContactExport(FileType.json);

        public ContactEdit()
        {
            contacts = contactImport.ImportContacts();
        }


        [Argument("a")]
        public void AddContact(string commandText)
        {
            contacts.Add(new Contact(commandText));
            contactExport.SaveContacts(contacts);
        }
    }
}
