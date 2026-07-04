using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

namespace InstallScriptGenerator.ApplicationLayers.HandlerLayer;

public interface ICommandHandler
{
    public List<CommandValidationReport> ValidateCommands();

    public void RunCommands();
}