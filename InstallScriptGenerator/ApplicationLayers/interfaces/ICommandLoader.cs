using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.Domain;

namespace InstallScriptGenerator.ApplicationLayers.interfaces;

public interface ICommandLoader
{
    public CommandLoaderReceipt GetCommands();
}

public class CommandLoaderReceipt
{
    public List<Command> Commands { get; set; } = new List<Command>();
    public List<CommandValidationRow> Receipts { get; set; } = new List<CommandValidationRow>();
}