using InstallScriptGenerator.ApplicationLayers.CommandLoaderLayer;
using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.ApplicationLayers.FactoryLayer;
using InstallScriptGenerator.Domain;

namespace InstallScriptGenerator.ApplicationLayers.HandlerLayer;

public class DefaultCommandHandler: ICommandHandler
{
    private readonly ICommandFactory _commandFactory;
    private readonly List<Command> _commands;
    private readonly List<CommandValidationRow> _loadingReport;

    public DefaultCommandHandler(ICommandFactory comFactory)
    {
        this._commandFactory = comFactory;
        CommandLoaderReceipt receipt = this._commandFactory.GetCommandLoader().GetCommands();
        this._commands = receipt.Commands;
        this._loadingReport = receipt.Receipts;
    }
    public List<CommandValidationReport> ValidateCommands()
    {
        List<CommandValidationReport> report = new List<CommandValidationReport>();
        foreach (var command in this.DuplicateCommandList())
        {
            report.Add(this._commandFactory.GetCommandBuilder(command.Type).ValidateCommand(command));
        }
        return report;
    }

    public List<CommandValidationRow> ValidateCorrectImport()
    {
        return this._loadingReport;
    }

    public void RunCommands()
    {
        throw new NotImplementedException();
    }

    /**
     * To make sure the command builder doesn't tamper with a command permanently
     * in the validation stage, and then fail in the actual building stage.
     */
    private List<Command> DuplicateCommandList()
    {
        List<Command> newList = new List<Command>();
        foreach (var cmd in this._commands)
        {
            newList.Add(cmd.GetCopy());
        }
        return newList;
    }
}