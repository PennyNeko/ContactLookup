using System;
using System.Collections.Generic;
using System.Reflection;

namespace ContactLookupDummy
{
    class Command
    {
        public Command(string commandName, Type classType, Dictionary<string, MethodInfo> methods)
        {
            CommandName = commandName;
            ClassType = classType;
            Methods = methods;
        }

        public string CommandName { set; get; }
        public Type ClassType { set; get; }
        public Dictionary<string, MethodInfo> Methods { set; get; }
    }
}
