using InstallScriptGenerator.ApplicationLayers.FactoryLayer;
using InstallScriptGenerator.ApplicationLayers.IncompleteRunExportLayer;

namespace InstallScriptGenerator.ApplicationLayers.HandlerLayer;

public class DefaultRunner(SystemFactory sysFactory, ICommandFactory comFactory, ICommandHandler handler)
    : IRunner
{
    private readonly SystemFactory _systemFactory = sysFactory;
    private readonly ICommandFactory _commandFactory = comFactory;
    private readonly ICommandHandler _handler = handler;

    public void RunFlow()
    {
        // get all the commands
        this._handler.ValidateCommands();
        // if fail, report the fails
        this._handler.RunCommands();
        // export the result
        throw new NotImplementedException();
    }
}