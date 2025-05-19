using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour
{
    public void VolverAlMenu()
    {
        Debug.Log("Cargando escena MenuPrincipal");
        SceneManager.LoadScene("MenuInicial");
    }
}
