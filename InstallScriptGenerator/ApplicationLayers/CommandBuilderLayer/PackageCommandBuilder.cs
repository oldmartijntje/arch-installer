using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.ApplicationLayers.interfaces;
using InstallScriptGenerator.Domain;

namespace InstallScriptGenerator.ApplicationLayers.CommandBuilderLayer;

public class PackageCommandBuilder: ICommandBuilder
{
    public CommandValidationReport ValidateCommand(Command cmd)
    {
        throw new NotImplementedException();
    }

    public ExportableCommand RunCommand(Command cmd)
    {
        throw new NotImplementedException();
    }
}