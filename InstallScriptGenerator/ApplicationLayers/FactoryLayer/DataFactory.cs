using InstallScriptGenerator.ApplicationLayers.DataStoreLayer;

namespace InstallScriptGenerator.ApplicationLayers.FactoryLayer;

public class DataFactory
{
    private Dictionary<string, IDataStore> _allDataStores = new Dictionary<string, IDataStore>();

    /**
     * Used for getting the right IDataStore.
     */
    public DataFactory(IDataStore defaultDataStore)
    {
        this.AddDataStore(defaultDataStore, "default");
    }

    public void AddDataStore(IDataStore dataStore, string key)
    {
        _allDataStores.Add(key, dataStore);
    }
    public IDataStore? GetCorrectDataStore(string? key)
    {
        if (key == null) key = "default";
        if (!this._allDataStores.ContainsKey(key)) return null;
        return this._allDataStores[key];
    }
}