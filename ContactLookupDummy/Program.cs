using System;
using System.Collections.Generic;

namespace ContactLookupDummy
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ICollection<Contact> contacts = new List<Contact>
            {
                new Contact("P", "T"),
                new Contact("J", "A")
            };
            JsonExport<Contact> contactExport = new JsonExport<Contact>();
            contactExport.JsonSave(contacts, "contacts");
        }
    }
}
