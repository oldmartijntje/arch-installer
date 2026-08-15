namespace InstallScriptGenerator.ApplicationLayers.helpers;

public class FileActionsHelper
{
    public static bool FileExists(string fileName)
    {
        return File.Exists(fileName);
    }
    
    public static bool DirectoryExists(string directoryName)
    {
        return Directory.Exists(directoryName);
    }

    public static bool CreateFile(string fileName, string content, bool? overwrite)
    {
        if (FileExists(fileName) && (overwrite == null || !overwrite.Value))
        {
            return false;
        }
        File.WriteAllText(fileName, content);
        return true;
    }

    public static bool DeleteFile(string fileName)
    {
        if (FileExists(fileName))
        {
            File.Delete(fileName);
            return true;
        }
        return false;
    }
}