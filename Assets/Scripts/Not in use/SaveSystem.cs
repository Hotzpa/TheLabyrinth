using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    
    

    public static void SavePlayer(Player player)
    {
        /*BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/Player.anything";
        FileStream stream = new FileStream(path, FileMode.Create);
       

        PlayerDataToSave data = new PlayerDataToSave(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

      public static void DefaultReset(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        
        string path = Application.persistentDataPath + "/Player.anything";
        FileStream stream = new FileStream(path, FileMode.Create);

        DefaultPlayerDataToSave data = new DefaultPlayerDataToSave(player);

        formatter.Serialize(stream,data);
        stream.Close();
    }

    public static PlayerDataToSave LoadPlayer()
    {

        string path = Application.persistentDataPath + "/Player.anything";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerDataToSave data = formatter.Deserialize(stream) as PlayerDataToSave;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }*/
    }

}
