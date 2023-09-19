using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SystemSaveLoad
{
    static string filePath = Application.persistentDataPath + "/playerData.dat";
    
    public static void Save(PlayerStats player)
    {
        BinaryFormatter format = new BinaryFormatter();
        FileStream fileStream = File.Open(filePath, FileMode.OpenOrCreate);

        SaveAndLoad data = new SaveAndLoad(player);
        format.Serialize(fileStream, data);
        fileStream.Close();
    }

    public static SaveAndLoad Load()
    {
        if (File.Exists(filePath))
        {
            BinaryFormatter format = new BinaryFormatter();
            FileStream fileStream = File.Open(filePath, FileMode.Open);
            SaveAndLoad data = format.Deserialize(fileStream) as SaveAndLoad;
            fileStream.Close();
            
            return data;

        }
        else
        {
            return null;
        }
    }
}
