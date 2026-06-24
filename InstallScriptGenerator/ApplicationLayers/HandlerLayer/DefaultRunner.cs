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
        throw new NotImplementedException();
    }
}