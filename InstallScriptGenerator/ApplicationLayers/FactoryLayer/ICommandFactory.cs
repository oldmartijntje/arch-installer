using InstallScriptGenerator.ApplicationLayers.CommandBuilderLayer;
using InstallScriptGenerator.ApplicationLayers.CommandExporterLayer;
using InstallScriptGenerator.ApplicationLayers.CommandLoaderLayer;

namespace InstallScriptGenerator.ApplicationLayers.FactoryLayer;

public interface ICommandFactory
{
    public ICommandExporter GetCommandExporter();
    public ICommandLoader GetCommandLoader();
    public ICommandBuilder GetCommandBuilder(string commandName);
}