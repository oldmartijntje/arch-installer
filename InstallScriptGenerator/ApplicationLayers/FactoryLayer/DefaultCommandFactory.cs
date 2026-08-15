using InstallScriptGenerator.ApplicationLayers.CommandBuilderLayer;
using InstallScriptGenerator.ApplicationLayers.CommandExporterLayer;
using InstallScriptGenerator.ApplicationLayers.CommandLoaderLayer;
using InstallScriptGenerator.ApplicationLayers.interfaces;

namespace InstallScriptGenerator.ApplicationLayers.FactoryLayer;

public class DefaultCommandFactory: ICommandFactory
{
    private readonly ICommandBuilder _packageCommandBuilder = new PackageCommandBuilder();
    private readonly ICommandLoader _commandLoader = new JsonCommandLoader();
    private readonly ICommandExporter _commandExporter = new TextCommandExporter();
    
    /**
     * Gets the correct command exporter, hardcoded definition
     */
    public ICommandExporter GetCommandExporter()
    {
        return this._commandExporter;
    }

    /**
     * Gets the correct command loader, hardcoded definition
     */
    public ICommandLoader GetCommandLoader()
    {
        return this._commandLoader;
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
                return this._packageCommandBuilder;
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