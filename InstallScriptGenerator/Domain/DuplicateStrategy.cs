namespace InstallScriptGenerator.Domain;

public class DuplicateStrategy
{
    public bool Ignore { get; set; }
    public bool Replace { get; set; }
    public bool AppendToName { get; set; }
    public string AppendToNameFormat{ get; set; } = string.Empty;
}