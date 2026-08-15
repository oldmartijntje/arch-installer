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

    public bool RunFlow()
    {
        // validate a correct import
        List<CommandValidationRow> importValidationResults = this._handler.ValidateCorrectImport();
        _systemFactory.GetMistakeExporter().Export(importValidationResults);
        if (!ReportHandler.IsRunnableInCurrentState(importValidationResults))
        {
            return false;
        }
        
        // get all the commands
        List<CommandValidationReport> commandValidationResults = this._handler.ValidateCommands();
        _systemFactory.GetMistakeExporter().Export(commandValidationResults);
        if (!ReportHandler.IsRunnableInCurrentState(commandValidationResults))
        {
            return false;
        }
        this._handler.RunCommands();
        // export the result
        throw new NotImplementedException();
    }
}