using InstallScriptGenerator.CommandLayers.CommandBuilderLayer;
using InstallScriptGenerator.CommandLayers.CommandExporterLayer;
using InstallScriptGenerator.CommandLayers.CommandLoaderLayer;

namespace InstallScriptGenerator.ApplicationLayers.FactoryLayer;

public class CommandFactory
{
    /**
     * Gets the correct command exporter, hardcoded definition
     */
    public ICommandExporter GetCommandExporter()
    {
        throw new NotImplementedException();
    }

    /**
     * Gets the correct command loader, hardcoded definition
     */
    public ICommandLoader GetCommandLoader()
    {
        throw new NotImplementedException();
    }
    
    /**
     * Gets the correct command builder based on the provided command type.
     */
    public ICommandBuilder GetCommandBuilder(string commandName)
    {
        switch (commandName)
        {
            case "exec-in":
                throw new NotImplementedException();
            case "var":
                throw new NotImplementedException();
            case "package":
                throw new NotImplementedException();
            case "git-clone":
                throw new NotImplementedException();
            case "exec":
                throw new NotImplementedException();
            case "define-custom":
                throw new NotImplementedException();
            default:
                // all other should return the custom command handler, which will have memory of whether it actually exists
                throw new NotImplementedException();
        }
        throw new NotImplementedException();
    }
}