using System;
using System.Reflection;

namespace ContactLookupDummy
{
    class MethodInvoker
    {
        object obj;
        readonly Type classType;
        public MethodInvoker(Type classType)
        {
            this.classType = classType;
        }
        public object CreateObject()
        {
            obj = Activator.CreateInstance(classType);
            return obj;
        }
        public object CreateObject(object[] arguments)
        {
            return obj = Activator.CreateInstance(classType, arguments);
        }

        public object InvokeMethod(MethodInfo method, object obj, object[] arguments)
        {
            return method.Invoke(obj, arguments);
        }

        public object InvokeMethod(MethodInfo method, object[] arguments)
        {
            return method.Invoke(obj ?? CreateObject(), arguments);
        }
    }
}
