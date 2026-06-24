using InstallScriptGenerator.Domain;

namespace InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

/**
 * This class is used for tracking errors in commands, it's validationrows are the individual errors/warnings.
 */
public class CommandValidationReport(Command command)
{
    private Command _validatedCommand = command;
    private readonly List<CommandValidationRow> _validationRows = new List<CommandValidationRow>();

    /**
     * Add a warning / error to the report
     */
    public void AddValidationRow(CommandValidationRow validationRow)
    {
        this._validationRows.Add(validationRow);
    }

    /**
     * Get all validation rows, aka get all warnings and errors
     */
    public List<CommandValidationRow> GetValidationRows()
    {
        return this._validationRows;
    }
}