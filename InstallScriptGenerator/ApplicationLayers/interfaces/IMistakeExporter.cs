using InstallScriptGenerator.ApplicationLayers.CommandValidationLayer;
using InstallScriptGenerator.ApplicationLayers.FactoryLayer;

namespace InstallScriptGenerator.ApplicationLayers.interfaces;

public interface IMistakeExporter
{
    public void Export(List<CommandValidationReport> reports);
    public void Export(List<CommandValidationRow> reports);
    public void ProvideSystemFactory(SystemFactory systemFactory);
}