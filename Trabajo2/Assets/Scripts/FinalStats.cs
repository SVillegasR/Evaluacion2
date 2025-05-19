using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FinalStats : MonoBehaviour
{
    public TMP_Text nombreText;
    public TMP_Text tiempoText;

    void Start()
    {
        string nombre = PlayerPrefs.GetString("Nombre", "Jugador");
        float tiempo = PlayerPrefs.GetFloat("TiempoFinal", 0f);

        nombreText.text = "Jugador: " + nombre;
        tiempoText.text = "Tiempo: " + tiempo.ToString("F2") + " segundos";
    }
}
