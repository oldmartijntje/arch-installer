using InstallScriptGenerator.Domain;

namespace InstallScriptGenerator.ApplicationLayers.CommandLoaderLayer;

public interface ICommandLoader
{
    public List<Command> GetCommands();
}