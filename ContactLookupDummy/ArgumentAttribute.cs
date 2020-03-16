using System;

namespace ContactLookupDummy
{
    internal class ArgumentAttribute : Attribute
    {


        public ArgumentAttribute(string argument)
        {
            Argument = argument;
        }

        public string Argument { set; get; }
    }
}