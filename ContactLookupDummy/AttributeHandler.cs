using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ContactLookupDummy
{
    class AttributeHandler
    {
        private IEnumerable<Type> GetCommandClasses()
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => x.IsClass).Where(x => x.GetCustomAttributes(typeof(CommandTypeAttribute), false).FirstOrDefault() != null);
        }

        private Type GetCommandClass(IEnumerable<Type> commandClasses, string commandName)
        {
            return commandClasses.Where(x => x.GetCustomAttributes(false).OfType<CommandTypeAttribute>().FirstOrDefault().CommandName == commandName).FirstOrDefault();
        }

        private IEnumerable<MethodInfo> GetMethodInfos(Type commandClass)
        {
            return commandClass.GetMethods().Where(x => x.GetCustomAttributes(typeof(ArgumentAttribute), false).FirstOrDefault() != null);
        }

        private MethodInfo GetMethodInfo(IEnumerable<MethodInfo> methods, string commandArgument)
        {
            return methods.Where(x => x.GetCustomAttributes(false).OfType<ArgumentAttribute>().FirstOrDefault().Argument == commandArgument).FirstOrDefault();
        }

        private string GetClassAttributeValue(Type classType)
        {
            return classType.GetCustomAttributes(false).OfType<CommandTypeAttribute>().FirstOrDefault().CommandName;
        }
        private string GetMethodAttributeValue(MethodInfo method)
        {
            return method.GetCustomAttributes(false).OfType<ArgumentAttribute>().FirstOrDefault().Argument;
        }

        public object InvokeCommand(Type classType, MethodInfo method, object[] commandArguments)
        {
            MethodInvoker methodInvoker = new MethodInvoker(classType);
            return methodInvoker.InvokeMethod(method, commandArguments);
        }

        public List<Command> CacheAllCommands()
        {
            List<Command> commands = new List<Command>();

            var commandClasses = GetCommandClasses();
            foreach (var c in commandClasses)
            {
                Dictionary<string, MethodInfo> methods = new Dictionary<string, MethodInfo>();
                var methodInfos = GetMethodInfos(c);
                foreach (var m in methodInfos)
                {
                    methods.Add(GetMethodAttributeValue(m), m);
                }

                commands.Add(new Command(GetClassAttributeValue(c), c, methods));
            }

            return commands;
        }
    }
}
