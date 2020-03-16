using System;

namespace ContactLookupDummy
{
    internal class CommandTypeAttribute : Attribute
    {

        public CommandTypeAttribute(string name)
        {
            CommandName = name;
        }

        public string CommandName { set; get; }
    }
}