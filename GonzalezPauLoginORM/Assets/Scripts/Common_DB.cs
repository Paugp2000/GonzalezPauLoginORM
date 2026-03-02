using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common_DB : MonoBehaviour
{
    public static string dbFolderPath = Application.streamingAssetsPath;
    public static string dbUri = "URI=file:" + dbFolderPath + "/MyDatabase.sqlite";
}
