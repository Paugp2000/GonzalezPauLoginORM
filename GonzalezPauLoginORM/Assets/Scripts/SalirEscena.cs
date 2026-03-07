using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirEscena : MonoBehaviour
{
    public void SalirEscenaBoton()
    {
        SceneManager.LoadScene("Login");
    }
}
