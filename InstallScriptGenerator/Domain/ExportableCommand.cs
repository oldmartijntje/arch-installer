namespace InstallScriptGenerator.Domain;

public class ExportableCommand
{
    private List<string> _values = [];

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

    public void AddValue(string value)
    {
        this._values.Add(value);
    }
    
}