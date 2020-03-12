using System;
using System.Collections.Generic;

namespace ContactLookupDummy
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CommandHandler commandHandler = new CommandHandler();
            commandHandler.Startup();
        }
    }
}
