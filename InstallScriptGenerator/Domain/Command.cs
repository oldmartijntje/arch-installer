namespace InstallScriptGenerator.Domain;

public class Command
{
    public string Type { get; set; }
    public string? Argument { get; set; }
    private string? Description { get; set; } = null;
    private List<Command> _subCommands = new List<Command>();
    private List<CommandField> _specificFields = new List<CommandField>();
    private List<string> _orderedFields = new List<string>();

    /**
     * The actual command, this holds the data of a specific command that will be executed. THis does not do the execution of itself, it only holds the data.
     */
    public Command(string type, string? argument, List<CommandField>? specificFields, List<Command>? subCommands, List<string>? orderedFields)
    {
        this.Type = type;
        this.Argument = argument;
        if (specificFields != null)
        {
            this._specificFields = specificFields;
        }
        if (subCommands != null)
        {
            this._subCommands = subCommands;
        }
        if (orderedFields != null)
        {
            this._orderedFields = orderedFields;
        }
    }

    /**
     * Simply getting the list of extra _specificFields
     */
    public List<CommandField>? GetSpecificFields()
    {
        return this._specificFields;
    }
    
    /**
     * Simply getting a specific item from this._specificFields
     */
    public string? GetSpecificFieldByKey(string index)
    {
        throw new NotImplementedException();
        // return this._specificFields
    }

    /**
     * Overwriting this._specificFields 
     */
    public void SetSpecificFields(List<CommandField> extraArguments)
    {
        this._specificFields = extraArguments;
    }

    /**
     * Add new item to the _specificFields dict
     */
    public void AddSpecificField(string key, string value)
    {
        this._specificFields.Add(new CommandField
        {
            Key = key,
            Value = value
        });
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
    public void SetSubCommands(List<Command> subCommands)
    {
        this._subCommands = subCommands;
    }

    /**
     * Add new item to the extra SubCommands
     */
    public void AddSubCommand(Command cmd)
    {
        this._subCommands.Add(cmd);
    }
    
    /**
     * Simply getting the list of OrderedFields
     */
    public List<string> GetOrderedFields()
    {
        return this._orderedFields;
    }
    
    /**
     * Simply getting a specific item from _orderedFields
     */
    public string? GetOrderedFieldByIndex(int index)
    {
        if (index < 0 || index >= this._subCommands.Count)
        {
            return null;
        }

        return this._orderedFields[index];
    }

    /**
     * Overwriting this._orderedFields
     */
    public void SetOrderedFields(List<string> fields)
    {
        this._orderedFields = fields;
    }

    /**
     * Add new item to the extra _orderedFields
     */
    public void AddOrderedField(string field)
    {
        this._orderedFields.Add(field);
    }

    /**
     * Duplicate the command, we do this before testing the commands, because the testing can possibly tamper with the commands and change the execution.
     */
    public Command GetCopy()
    {
        return new Command(this.Type, this.Argument, this._specificFields, this._subCommands, this._orderedFields);
    }

    public class CommandField
    {
        public required string Key { get; set; }
        public required string Value { get; set; }
    }
}