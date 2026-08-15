using InstallScriptGenerator.ApplicationLayers.CommandLoaderLayer;

namespace InstallScriptGenerator.ApplicationLayers.interfaces;

public interface ICommandFactory
{
    public ICommandExporter GetCommandExporter();
    public ICommandLoader GetCommandLoader();
    public ICommandBuilder GetCommandBuilder(string commandName);
}