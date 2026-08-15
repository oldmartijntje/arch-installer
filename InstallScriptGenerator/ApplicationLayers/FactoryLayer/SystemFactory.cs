using InstallScriptGenerator.ApplicationLayers.interfaces;

namespace InstallScriptGenerator.ApplicationLayers.FactoryLayer;

public class SystemFactory
{
    private readonly IMistakeExporter _mistakeExporter;
    private readonly HealthTracker _healthTracker = new HealthTracker();

    public SystemFactory(IMistakeExporter mistakeExporter)
    {
        this._mistakeExporter = mistakeExporter;
    }
    public IMistakeExporter GetMistakeExporter()
    {
        return _mistakeExporter;
    }

    public HealthTracker GetHealthTracker()
    {
        return this._healthTracker;
    }
}