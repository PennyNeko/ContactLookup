using Newtonsoft.Json;

namespace ContactLookupDummy
{
    class Program
    {

        static void Main(string[] args)
        {
            CommandHandler commandHandler = new CommandHandler();
            commandHandler.ArgumentHandling(args);
        }
    }
}
