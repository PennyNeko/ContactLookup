using System;

namespace ContactLookupDummy
{
    internal class CommandTypeAttribute : Attribute
    {

        public CommandTypeAttribute(string name)
        {
            CommandType = name;
        }

        private string CommandType { set; get; }
    }
}