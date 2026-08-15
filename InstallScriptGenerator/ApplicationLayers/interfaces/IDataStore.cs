namespace InstallScriptGenerator.ApplicationLayers.DataStoreLayer;

/**
 * The datastore's are used by the commandBuilders in order to share data between multiple fire's, or between commands.
 * Only has support for strings and intagers (so also booleans).
 */
public interface IDataStore
{
    public string? GetStringItem(string key,  string? defaultValue);
    public List<string> GetStringKeys();
    public void SetStringItem(string key, string value);
    public int? GetIntItem(string key, int? defaultValue);
    public List<string> GetIntKeys();
    public void SetIntItem(string key, int value);
}