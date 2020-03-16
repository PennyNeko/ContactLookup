using System;
using System.Collections;
using System.Collections.Generic;

namespace ContactLookupDummy
{
    class CommandHandler
    {
        AttributeHandler attributeHandler = new AttributeHandler();
        List<Command> commands;
        public CommandHandler()
        {
            commands = attributeHandler.CacheAllCommands();
        }
        public void ArgumentHandling(string[] consoleText)
        {
            string commandName = consoleText[0];
            string commandArgument = consoleText[1];
            string commandText = consoleText[2];
            CallCommand(commandName, commandArgument, commandText);
        }

        public void CallCommand(string commandName, string commandArgument, string commandText)
        {
            object result = null;

            foreach (var c in commands)
            {
                if (c.CommandName == commandName)
                {
                    result = attributeHandler.InvokeCommand(c.ClassType, c.Methods[commandArgument], new object[] { commandText });
                }
            }
            if (result != null)
            {
                Console.WriteLine(ResultHandling(result));    
            }
        }

        public string ResultHandling(object result)
        {
            IPrintable printer;
            if (result is ICollection)
            {
                string mergedText = "";
                foreach(var r in (ICollection)result)
                {
                    printer = (IPrintable)r;
                    mergedText += printer.Print()+"\n";
                }
                return mergedText;
            }
            printer = (IPrintable)result;
            return printer.ToString();
        }
    }
}
