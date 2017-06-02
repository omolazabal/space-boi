using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class DataManagment : MonoBehaviour {

    public static DataManagment datamanagment;

    public int currentScore;
    public int highScore;
    public int coinsCollected;

    void Awake()
    {
        if (datamanagment == null)
        {
            DontDestroyOnLoad(gameObject);
            datamanagment = this;
        }
        else if (datamanagment != this)
        {
            Destroy(gameObject);
        }
    }

    public void SaveData ()
    {
        BinaryFormatter binForm = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gameInfo.dat");
        gameData data = new gameData();
        data.highScore = highScore;
        data.coinsCollected = coinsCollected;
        binForm.Serialize(file, data);
        file.Close();
    }

    public void LoadData ()
    {
        if (File.Exists (Application.persistentDataPath + "/gameInfo.dat"))
        {
            BinaryFormatter binForm = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gameInfo.dat", FileMode.Open);
            gameData data = (gameData)binForm.Deserialize(file);
            file.Close();
            highScore = data.highScore;
            coinsCollected = data.coinsCollected;
        }
    }
}


[Serializable]
class gameData
{
    public int highScore;
    public int coinsCollected;

}