using InstallScriptGenerator.ApplicationLayers.FactoryLayer;
using InstallScriptGenerator.ApplicationLayers.IncompleteRunExportLayer;

namespace InstallScriptGenerator.ApplicationLayers.HandlerLayer;

public class DefaultRunner(SystemFactory sysFactory, CommandFactory comFactory, CommandHandler handler)
    : IRunner
{
    private SystemFactory _systemFactory = sysFactory;
    private CommandFactory _commandFactory = comFactory;
    private CommandHandler _handler = handler;

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