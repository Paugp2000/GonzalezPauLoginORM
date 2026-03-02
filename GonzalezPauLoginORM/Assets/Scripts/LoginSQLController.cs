using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using TMPro;
using UnityEngine;


using Mono.Data.Sqlite;
using Unity.VisualScripting.Dependencies.Sqlite;
public class LoginSQLController : MonoBehaviour
{
    private string dbUri;
    private IDbConnection dbConnection;
    public static int idUsuario;
    [SerializeField] TMP_InputField nombreUsuario;
    [SerializeField] TMP_InputField contraseña;
    [SerializeField] GameObject panelErrorUsuario;
    [SerializeField] GameObject panelErrorContraseña;
    [SerializeField] GameObject panelErrorConPequeña;

    private void Start()
    {

        AssertFolder();
        
        dbConnection = new SqliteConnection(Common_DB.dbUri);
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
        dbConnection.Open();
        //dbConnection.Databa
    }
}
