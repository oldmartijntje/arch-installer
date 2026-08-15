using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.ApplicationLayers.FactoryLayer;
using InstallScriptGenerator.ApplicationLayers.interfaces;

namespace InstallScriptGenerator.ApplicationLayers.HandlerLayer;

public class DefaultRunner(SystemFactory sysFactory, ICommandFactory comFactory, ICommandHandler handler)
    : IRunner
{
    private readonly SystemFactory _systemFactory = sysFactory;
    private readonly ICommandFactory _commandFactory = comFactory;
    private readonly ICommandHandler _handler = handler;

    public void RunFlow()
    {
        // validate a correct import
        List<CommandValidationRow> importValidationResults = this._handler.ValidateCorrectImport();
        if (!ReportHandler.IsRunnableInCurrentState(importValidationResults))
        {
            throw new NotImplementedException(); // have to do something with the output of the above command
        }
        
        // get all the commands
        List<CommandValidationReport> commandValidationResults = this._handler.ValidateCommands();
        if (!ReportHandler.IsRunnableInCurrentState(commandValidationResults))
        {
            throw new NotImplementedException(); // have to do something with the output of the above command
        }
        this._handler.RunCommands();
        // export the result
        throw new NotImplementedException();
    }
}