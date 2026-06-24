namespace InstallScriptGenerator.Domain;

public class ExportableCommand
{
    private List<string> _values = [];

    /**
     * The class that will be used for the actual output.
     * This class holds 1 or multiple lines, that will be outputted into the preferred structure, like a list of commands in a .txt
     */
    public ExportableCommand(List<string>? values)
    {
        if (values != null)
        {
            this._values = values;
        }
    }
    
    public List<string> Values
    {
        get { return this._values; }
    }

    /**
     * Adding an item to the ExportableCommand
     */
    public void AddValue(string value)
    {
        this._values.Add(value);
    }
}