using System.Collections.Generic;

namespace ContactLookupDummy
{
    class CommandExport : JsonSerialize<ICollection<Command>>
    {
        public void SetCommands(ICollection<Command> commands, string fileName = "commands")
        {
            Save(commands, fileName);
        }
    }
}
