namespace InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

public class CommandValidationWarningState : ICommandValidationState
{
    public bool IsBlocking()
    {
        return false;
    }

    public bool IsIgnorableInformation()
    {
        return false;
    }
}