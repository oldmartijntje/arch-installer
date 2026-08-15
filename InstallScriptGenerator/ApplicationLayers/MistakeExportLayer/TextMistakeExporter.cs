using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.ApplicationLayers.HandlerLayer;
using InstallScriptGenerator.ApplicationLayers.helpers;
using InstallScriptGenerator.ApplicationLayers.interfaces;

namespace InstallScriptGenerator.ApplicationLayers.MistakeExportLayer;

public class TextMistakeExporter: IMistakeExporter
{
    private string _currentText = "";
    private const string ERROR_FILE_LOCATION = "errors.txt";
    private const string WARNING_FILE_LOCATION = "warning.txt";
    private bool _consolePrint = true;

    public TextMistakeExporter(bool concolePrint)
    {
        _consolePrint = concolePrint;
    }
    
    public void Export(List<CommandValidationReport> reports)
    {
        foreach (var report in reports)
        {
            report.GetValidationRows().ForEach(row =>
            {
                string status = row.State.IsBlocking() ? "ERROR" : "WARNING";
                this._currentText += $"{status} found in command {report.GetCommandClone().Type}:\n{row.Text}\n\n";
            });
        }
        this.ExportFile(ReportHandler.IsRunnableInCurrentState(reports));
    }

    public void Export(List<CommandValidationRow> reports)
    {
        foreach (var report in reports)
        {
            string status = report.State.IsBlocking() ? "ERROR" : "WARNING";
            this._currentText += $"{status} whilst importing commands:\n{report.Text}\n\n";
        }
        this.ExportFile(ReportHandler.IsRunnableInCurrentState(reports));
    }
    
    private void ExportFile(bool isRunnableInCurrentState)
    {
        string fileName = isRunnableInCurrentState ? WARNING_FILE_LOCATION : ERROR_FILE_LOCATION;
        FileActionsHelper.CreateFile(fileName, _currentText, true);
        if (_consolePrint)
        {
            Console.WriteLine(_currentText);
        }
        Console.WriteLine($"Exported log to {fileName}");
    }
}