using Newtonsoft.Json;

namespace ContactLookupDummy
{
    class Contact : IPrintable
    {
        [JsonConstructor]
        public Contact(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Contact(string contactInfo)
        { 
            string[] splitContactInfo = contactInfo.Split(",");
            FirstName = splitContactInfo[0];
            LastName = splitContactInfo[1];
        }
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public string Print()
        {
            string text = $"Full Name: {FirstName} {LastName}";
            return text;
        }

    }
}
