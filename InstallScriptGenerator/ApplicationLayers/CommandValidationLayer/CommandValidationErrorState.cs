namespace InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

public class CommandValidationErrorState : ICommandValidationState
{
    public static bool IsBlocking()
    {
        return true;
    }

    public static bool IsIgnorableInformation()
    {
        return false;
    }
}