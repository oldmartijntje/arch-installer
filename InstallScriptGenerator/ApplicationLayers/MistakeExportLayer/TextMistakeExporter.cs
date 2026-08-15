using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.ApplicationLayers.FactoryLayer;
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
    private SystemFactory? _systemFactory;

    public TextMistakeExporter(bool concolePrint)
    {
        _consolePrint = concolePrint;
    }
    
    public void Export(List<CommandValidationReport> reports)
    {
        string cache = this._currentText;
        foreach (var report in reports)
        {
            report.GetValidationRows().ForEach(row =>
            {
                string status = row.State.IsBlocking() ? "ERROR" : "WARNING";
                this._currentText += $"{status} found in command {report.GetCommandClone().Type}:\n{row.Text}\n\n";
            });
        }

        if (cache != this._currentText)
        {
            this.ExportFile(ReportHandler.IsRunnableInCurrentState(reports));
        }
    }

    public void Export(List<CommandValidationRow> reports)
    {
        string cache = this._currentText;
        foreach (var report in reports)
        {
            string status = report.State.IsBlocking() ? "ERROR" : "WARNING";
            this._currentText += $"{status} whilst importing commands:\n{report.Text}\n\n";
        }
        if (cache != this._currentText)
        {
            this.ExportFile(ReportHandler.IsRunnableInCurrentState(reports));
        }
    }

    public void ProvideSystemFactory(SystemFactory systemFactory)
    {
        this._systemFactory = systemFactory;
    }

    private void ExportFile(bool isRunnableInCurrentState)
    {
        string fileName = isRunnableInCurrentState ? WARNING_FILE_LOCATION : ERROR_FILE_LOCATION;
        var systemFactory = this._systemFactory;
        string fileText;
        if (systemFactory != null)
        {
            fileText = $"Program start time: {systemFactory.GetHealthTracker().StartTime}";
        }
        else
        {
            fileText = $"Program start time: UNKNOWN";
        }

        fileText += $"\nExport time: {DateTime.Now}\n{this._currentText}";

        FileActionsHelper.CreateFile(fileName, fileText, true);
        if (_consolePrint)
        {
            Console.WriteLine(fileText);
        }
        Console.WriteLine($"Exported log to {fileName}");
    }
}