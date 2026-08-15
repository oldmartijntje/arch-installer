using InstallScriptGenerator.ApplicationLayers.CommandBuilderLayer;
using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.ApplicationLayers.interfaces;
using InstallScriptGenerator.Domain;
using Newtonsoft.Json;

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
        CommandLoaderReceipt receipt = new CommandLoaderReceipt();
        try
        {
            var jsonString = File.ReadAllText(this._jsonFilePath);
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
        
            var rootCommands = JsonConvert.DeserializeObject<List<ImportedCommand>>(
                jsonString,
                settings
            );
            if (rootCommands == null)
            {
                receipt.Receipts.Add(new CommandValidationRow($"{this._jsonFilePath} is parsed into null, something is invalid", new CommandValidationErrorState()));
                return receipt;
            }
            receipt.Commands = this.MapCommands(rootCommands);
            return receipt;
        }
        catch (JsonException ex)
        {
            receipt.Receipts.Add(new CommandValidationRow($"Failed to parse JSON command file: {ex.Message}", new CommandValidationErrorState()));
            return receipt;
        }
        catch (Exception ex)
        {
            receipt.Receipts.Add(new CommandValidationRow($"Unexpected error loading commands: {ex.Message}", new CommandValidationErrorState()));
            return receipt;
        }
    }

    private List<Command> MapCommands(List<ImportedCommand> importedCommands)
    {
        throw new NotImplementedException();
    }
    
    private Command MapCommand(ImportedCommand importedCommand)
    {
        throw new NotImplementedException();
    }
}

internal class ImportedCommand
{
    public required string Command { get; set; }
    public string? Argument { get; set; }
    public string? Desc { get; set; }
    public List<ImportedCommand>? SubCommands { get; set; }
    public List<ImportedCommandField>? SpecificFields { get; set; }
    public List<string>? OrderedFields { get; set; }
    
    internal class ImportedCommandField
    {
        public required string Key { get; set; }
        public required string Value { get; set; }
    }
}
