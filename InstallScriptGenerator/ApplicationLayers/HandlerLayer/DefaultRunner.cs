using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.ApplicationLayers.FactoryLayer;

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
        List<CommandValidationRow> validationResults = this._handler.ValidateCorrectImport();
        throw new NotImplementedException(); // have to do something with the output of the above command
        // get all the commands
        this._handler.ValidateCommands();
        throw new NotImplementedException(); // have to do something with the output of the above command
        // if fail, report the fails
        this._handler.RunCommands();
        // export the result
        throw new NotImplementedException();
    }
}