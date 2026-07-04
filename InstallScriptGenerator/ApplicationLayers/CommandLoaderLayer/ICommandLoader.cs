using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.Domain;

namespace InstallScriptGenerator.ApplicationLayers.CommandLoaderLayer;

public interface ICommandLoader
{
    public CommandLoaderReceipt GetCommands();
}

public class CommandLoaderReceipt
{
    public List<Command> Commands { get; set; }
    public List<CommandValidationRow> Receipts { get; set; }
}