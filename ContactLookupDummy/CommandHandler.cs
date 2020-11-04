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
            CommandExport commandExport = new CommandExport();
            commandExport.SetCommands(commands);
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
                    break;
                }
            }
            if (result != null)
            {
                Console.WriteLine(ResultHandling(result));
            }
        }

        public string ResultHandling(object result)
        {
            string mergedText = "";
            foreach (var r in (IEnumerable)result)
            {
                if (r is string)
                {
                    mergedText += r;
                }
                else if (r is IPrintable)
                {
                    mergedText += ((IPrintable)r).Print() + "\n";
                }
            }
            return mergedText;
        }
    }
}
