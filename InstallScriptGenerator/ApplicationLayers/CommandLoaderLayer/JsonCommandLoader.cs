using InstallScriptGenerator.ApplicationLayers.CommandBuilderLayer;
using InstallScriptGenerator.Domain;

namespace InstallScriptGenerator.ApplicationLayers.CommandLoaderLayer;

public class JsonCommandLoader: ICommandLoader
{
    private readonly string _jsonFilePath;
    public JsonCommandLoader()
    {
        this._jsonFilePath = "assets/input.json";
    }
    public CommandLoaderReceipt GetCommands()
    {
        var jsonString = File.ReadAllText(this._jsonFilePath);
        Console.WriteLine(jsonString);
        throw new NotImplementedException();
    }
}

internal class ImportedCommand
{
    public string Command { get; set; }
    public string? Argument { get; set; }
    public string? Desc { get; set; }
    public List<ImportedCommand>? SubCommands { get; set; }
    public List<ImportedCommandField>? SpecificFields { get; set; }
    public List<string>? OrderedFields { get; set; }
    
    internal class ImportedCommandField
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
