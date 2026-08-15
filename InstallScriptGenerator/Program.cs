using InstallScriptGenerator.ApplicationLayers.DataStoreLayer;
using InstallScriptGenerator.ApplicationLayers.FactoryLayer;
using InstallScriptGenerator.ApplicationLayers.HandlerLayer;
using InstallScriptGenerator.ApplicationLayers.interfaces;
using InstallScriptGenerator.ApplicationLayers.MistakeExportLayer;

namespace InstallScriptGenerator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        DataFactory dataFactory = new DataFactory(new DefaultDataStore());
        IMistakeExporter mistakeExporter = new TextMistakeExporter(true);
        SystemFactory systemFactory = new SystemFactory(mistakeExporter);
        ICommandFactory commandFactory = new DefaultCommandFactory();
        ICommandHandler commandHandler = new DefaultCommandHandler(commandFactory);
        IRunner defaultRunner = new DefaultRunner(systemFactory, commandFactory, commandHandler);
        defaultRunner.RunFlow();
        Console.WriteLine("Bye, World!");
    }
}