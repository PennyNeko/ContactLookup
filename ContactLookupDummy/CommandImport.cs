using System;
using System.Collections.Generic;
using System.Text;

namespace ContactLookupDummy
{
    class CommandImport : JsonImport<ICollection<Command>>
    {
        public ICollection<Command> ImportCommands(string fileName = "commands")
        {
            return JsonSave(fileName);
        }
    }
}
