using System;
using System.Collections.Generic;
using System.Text;

namespace ContactLookupDummy
{
    class Command
    {
        public Command(string commandName, Type commandType, string[] argumentNames, Type[] arguments)
        {
            CommandName = commandName;
            CommandType = commandType;
            ArgumentNames = argumentNames;
            Arguments = arguments;
        }

        public string CommandName { set; get; }
        public Type CommandType { set; get; }
        public string[] ArgumentNames { set; get; }
        public Type[] Arguments { set; get; } 
        public string CommandInformation { set; get; }
    }
}
