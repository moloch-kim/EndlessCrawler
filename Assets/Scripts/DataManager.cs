using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public void SaveData<T>(T data)
    {
        string Json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath, Json);
    } 
}
