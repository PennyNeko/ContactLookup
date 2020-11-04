using System.Collections.Generic;

namespace ContactLookupDummy
{
    class CommandImport : JsonDeserialize<ICollection<Command>>
    {
        public ICollection<Command> ImportCommands(string fileName = "commands")
        {
            return Load(fileName);
        }
    }
}
