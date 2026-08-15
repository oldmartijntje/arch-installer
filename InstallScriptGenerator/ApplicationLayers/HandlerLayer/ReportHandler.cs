using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

namespace InstallScriptGenerator.ApplicationLayers.HandlerLayer;

public static class ReportHandler
{
    public static bool IsRunnableInCurrentState(List<CommandValidationReport> validationResults)
    {
        return !validationResults.Any(report =>
            report.GetValidationRows().Any(row => row.State.IsBlocking())
        );
    }
    
    public static bool IsRunnableInCurrentState(List<CommandValidationRow> validationResults)
    {
        foreach (var validationResult in validationResults)
        {
            if (validationResult.State.IsBlocking())
            {
                return false;
            }
        }
        return true;
    }
}