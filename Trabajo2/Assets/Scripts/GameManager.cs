using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public TMP_Text nombreJugadorText;
    public TMP_Text dificultadText;
    public AudioSource backgroundMusic;
    void Start()
    {
        // Obtener datos guardados
        string nombre = PlayerPrefs.GetString("Nombre", "Jugador");
        int dificultad = PlayerPrefs.GetInt("Dificultad", 0); // 0: Fácil, 1: Media, 2: Difícil
        float volumen = PlayerPrefs.GetFloat("Volumen", 1f);  // Por defecto volumen completo
        backgroundMusic.volume = volumen;
        // Mostrar nombre del jugador
        if (nombreJugadorText != null)
            nombreJugadorText.text = "Jugador: " + nombre;

        // Mostrar dificultad
        if (dificultadText != null)
        {
            string dificultadStr = "Fácil";
            if (dificultad == 1) dificultadStr = "Media";
            else if (dificultad == 2) dificultadStr = "Difícil";

            dificultadText.text = "Dificultad: " + dificultadStr;
        }

        
    }
}