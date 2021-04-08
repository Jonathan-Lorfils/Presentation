using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using UnityEngine;

public class SauvegarderFichier : MonoBehaviour
{
    public static void Save(int score)
    {
        string path = Application.persistentDataPath + "/score";
        FileStream stream = new FileStream(path, FileMode.Create);
        stream.Close();
    }
}
