namespace InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

public class CommandValidationErrorState : ICommandValidationState
{
    public bool IsBlocking()
    {
        return true;
    }

    public bool IsIgnorableInformation()
    {
        return false;
    }
}