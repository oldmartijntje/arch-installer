using InstallScriptGenerator.ApplicationLayers.interfaces;

namespace InstallScriptGenerator.ApplicationLayers.FactoryLayer;

public class SystemFactory
{
    private readonly IMistakeExporter _mistakeExporter;

    public SystemFactory(IMistakeExporter mistakeExporter)
    {
        this._mistakeExporter = mistakeExporter;
    }
    public IMistakeExporter GetMistakeExporter()
    {
        return _mistakeExporter;
    }
}