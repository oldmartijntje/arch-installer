using InstallScriptGenerator.ApplicationLayers.DataStoreLayer;
using InstallScriptGenerator.ApplicationLayers.FactoryLayer;
using InstallScriptGenerator.ApplicationLayers.HandlerLayer;
using InstallScriptGenerator.ApplicationLayers.IncompleteRunExportLayer;

namespace InstallScriptGenerator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        DataFactory dataFactory = new DataFactory(new DefaultDataStore());
        SystemFactory systemFactory = new SystemFactory();
        CommandFactory commandFactory = new CommandFactory();
        CommandHandler commandHandler = new CommandHandler();
        IRunner defaultRunner = new DefaultRunner(systemFactory, commandFactory, commandHandler);
        defaultRunner.RunFlow();
        Console.WriteLine("Bye, World!");
    }
}