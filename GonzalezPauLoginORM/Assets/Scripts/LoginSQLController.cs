using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using TMPro;
using UnityEngine;
using SQLite4Unity3d;

using Mono.Data.Sqlite;
public class LoginSQLController : MonoBehaviour
{
    private string dbUri;
    public static int idUsuario;
    private SQLiteConnection dbConnection;


    [SerializeField] TMP_InputField nombreUsuario;
    [SerializeField] TMP_InputField contraseña;
    [SerializeField] GameObject panelErrorUsuario;
    [SerializeField] GameObject panelErrorContraseña;
    [SerializeField] GameObject panelErrorConPequeña;

    private void Start()
    {

        AssertFolder();
        
        dbConnection = new SQLiteConnection(Common_DB.dbUri);
        CreateDatabaseIfNecessary();
    }
    void AssertFolder()
    {
        if (!Directory.Exists(Common_DB.dbFolderPath))
        {
            Directory.CreateDirectory(Common_DB.dbFolderPath);
        }
    }

    public void CreateDatabaseIfNecessary()
    {
        dbConnection.CreateTable<Usuario>();
    }
}
