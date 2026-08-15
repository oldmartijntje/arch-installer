using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;

namespace InstallScriptGenerator.ApplicationLayers.interfaces;

public interface IMistakeExporter
{
    public void Export(List<CommandValidationReport> reports);
    public void Export(List<CommandValidationRow> reports);
}