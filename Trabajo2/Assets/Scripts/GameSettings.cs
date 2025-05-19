using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameSettings : MonoBehaviour
{
    public TMP_Text nombreJugadorText;
    public AudioSource backgroundMusic;
    public TMP_Text dificultadTexto;
    void Start()
    {
        string nombre = PlayerPrefs.GetString("Nombre", "Jugador");
        nombreJugadorText.text = nombre;
        int dificultad = PlayerPrefs.GetInt("Dificultad", 0);
        dificultadTexto.text = "Dificultad: " + dificultad;
        float volumen = PlayerPrefs.GetFloat("Volumen", 1f);  // Por defecto volumen completo
        backgroundMusic.volume = volumen;

    }
}
