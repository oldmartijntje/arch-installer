namespace InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

public interface ICommandValidationState
{
    /**
     * Whether or not the program shall progress if this is returned.
     */
    public bool IsBlocking();
    
    /**
     * Whether or not this is important information that the user must know.
     * General rule of thumb: is it dangerous or something that breaks the program, then it is not ignorable.
     * Hints can be usefull and ignorable.
     */
    public bool IsIgnorableInformation();
}