using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace ContactLookupDummy
{
    class CommandHandler
    {
        List<Command> commands = new List<Command>();
        public void Startup()
        {
            var classes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => x.IsClass);
            foreach (var cl in classes)
            {
                if (cl.GetCustomAttributes().Any())
                {
                    List<Type> methods = new List<Type>();
                    List<string> methodNames = new List<string>();
                    foreach (var method in cl.GetMethods())
                    {
                        methods.Add(method.GetType());
                        methodNames.Add(method.CustomAttributes.Select(x => x.ConstructorArguments).First().ToString());
                    }
                    Type[] methodTypes = methods.ToArray();
                    commands.Add(new Command(cl.CustomAttributes.Select(x => x.ConstructorArguments).First().ToString(), cl, methodNames.ToArray(), methodTypes));
                }
            }
            foreach(var command in commands)
            {
                Console.WriteLine(command.CommandName + command.CommandType + command.ArgumentNames + command.Arguments);
            }
        }
       
        public void CallCommand(string text)
        {
            string[] commandArguments = text.Split(" ");

        }
    }
}
