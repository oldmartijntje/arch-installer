namespace InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

public class CommandValidationWarningState : ICommandValidationState
{
    public static bool IsBlocking()
    {
        return false;
    }

    public static bool IsIgnorableInformation()
    {
        return false;
    }
}