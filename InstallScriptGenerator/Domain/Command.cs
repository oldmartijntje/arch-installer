namespace InstallScriptGenerator.Domain;

public class Command
{
    public string Type { get; set; }
    private Dictionary<string, string> _extraArguments = [];
    public string Argument  { get; set; }
    private List<Command> _subCommands = [];

    public Command(string type, string argument, Dictionary<string, string>? extraArguments, List<Command>? subCommands)
    {
        this.Type = type;
        this.Argument = argument;
        if (extraArguments != null)
        {
            this._extraArguments = extraArguments;
        }

        if (subCommands != null)
        {
            this._subCommands = subCommands;
        }
    }

    /**
     * Simply getting the list of extra arguments
     */
    public Dictionary<string, string> GetExtraArguments()
    {
        return this._extraArguments;
    }
    
    /**
     * Simply getting a specific item from this._extraArguments
     */
    public string? GetExtraArgumentByKey(string index)
    {
        return this._extraArguments.GetValueOrDefault(index);
    }

    /**
     * Overwriting this._extraArguments 
     */
    public void SetExtraArguments(Dictionary<string, string> extraArguments)
    {
        this._extraArguments = extraArguments;
    }

    /**
     * Add new item to the extra arguments dict
     */
    public void AddExtraArgument(string key, string value)
    {
        this._extraArguments.Add(key, value);
    }
    
    /**
     * Simply getting the list of SubCommands
     */
    public List<Command> GetSubCommands()
    {
        return this._subCommands;
    }
    
    /**
     * Simply getting a specific item from this._SubCommands
     */
    public Command? GetSubCommandByIndex(int index)
    {
        if (index < 0 || index >= this._subCommands.Count)
        {
            return null;
        }

        return this._subCommands[index];
    }

    /**
     * Overwriting this._SubCommands
     */
    public void SetExtraArguments(List<Command> subCommands)
    {
        this._subCommands = subCommands;
    }

    /**
     * Add new item to the extra SubCommands
     */
    public void AddExtraArgument(Command cmd)
    {
        this._subCommands.Add(cmd);
    }
    
}