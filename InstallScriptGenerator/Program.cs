using InstallScriptGenerator.ApplicationLayers.DataStoreLayer;
using InstallScriptGenerator.ApplicationLayers.FactoryLayer;

namespace InstallScriptGenerator;

class Program
{
    static void Main(string[] args)
    {
        DataFactory dataFactory = new DataFactory(new DefaultDataStore());
        Console.WriteLine("Hello, World!");
    }
}