using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.Domain;

namespace InstallScriptGenerator.ApplicationLayers.CommandBuilderLayer;

public interface ICommandBuilder
{
    public CommandValidationReport ValidateCommand(Command cmd);
    public ExportableCommand RunCommand(Command cmd);
}