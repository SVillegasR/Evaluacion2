using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Dropdown difficultyDropdown;
    public Slider volumeSlider;

    public void OnStartGame()
    {
        // Guardar configuraciones
        PlayerPrefs.SetString("Nombre", nameInput.text);
        PlayerPrefs.SetInt("Dificultad", difficultyDropdown.value);
        PlayerPrefs.SetFloat("Volumen", volumeSlider.value);

        // Cargar escena del juego
        SceneManager.LoadScene("Juego"); // Cambia "Juego" por el nombre exacto de tu escena del juego
    }
}
