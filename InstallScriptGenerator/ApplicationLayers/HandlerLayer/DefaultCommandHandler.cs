using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.ApplicationLayers.FactoryLayer;
using InstallScriptGenerator.Domain;

namespace InstallScriptGenerator.ApplicationLayers.HandlerLayer;

public class DefaultCommandHandler: ICommandHandler
{
    private readonly ICommandFactory _commandFactory;
    private readonly List<Command> _commands;

    public DefaultCommandHandler(ICommandFactory comFactory)
    {
        this._commandFactory = comFactory;
        this._commands = this._commandFactory.GetCommandLoader().GetCommands();
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
        throw new NotImplementedException();
    }
}