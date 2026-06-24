namespace InstallScriptGenerator.ApplicationLayers.DataStoreLayer;

public class DefaultDataStore : IDataStore
{
    private Dictionary<string, string> _stringDatas = new Dictionary<string, string>();
    private Dictionary<string, int> _intDatas = new Dictionary<string, int>();
    public int? GetIntItem(string key, int? defaultValue)
    {
        if (!this._intDatas.ContainsKey(key))
        {
            if (defaultValue.HasValue)
            {
                this.SetIntItem(key, defaultValue.Value);
                return defaultValue;
            }
            return null;
        }

        return this._intDatas[key];
    }

    public List<string> GetIntKeys()
    {
        return this._intDatas.Keys.ToList();
    }

    public void SetIntItem(string key, int value)
    {
        this._intDatas[key] = value;
    }
    
    public string? GetStringItem(string key, string? defaultValue)
    {
        if (!this._stringDatas.ContainsKey(key))
        {
            if (defaultValue != null)
            {
                this.SetStringItem(key, defaultValue);
                return defaultValue;
            }
            return null;
        }

        return this._stringDatas[key];
    }

    public List<string> GetStringKeys()
    {
        return this._stringDatas.Keys.ToList();
    }

    public void SetStringItem(string key, string value)
    {
        this._stringDatas[key] = value;
    }
}