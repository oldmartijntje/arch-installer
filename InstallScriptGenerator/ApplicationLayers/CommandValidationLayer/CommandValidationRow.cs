namespace InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

public class CommandValidationRow(string text, ICommandValidationState state)
{
    public string Text { get; set; } = text;
    public required ICommandValidationState State { get; set; } = state;
}