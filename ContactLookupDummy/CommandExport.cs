using System.Collections.Generic;

namespace ContactLookupDummy
{
    class CommandExport : JsonExport<ICollection<Command>>
    {
        public void SetCommands(ICollection<Command> commands, string fileName = "commands")
        {
            JsonSave(commands, fileName);
        }
    }
}
