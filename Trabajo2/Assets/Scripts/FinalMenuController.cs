using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalMenuController : MonoBehaviour
{
    public void VolverAlMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}
