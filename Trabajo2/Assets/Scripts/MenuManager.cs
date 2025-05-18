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
    public AudioSource musicSource;

    public static string playerName;
    public static int difficultyIndex;
    public static float volumeLevel;

    void Start()
    {
        // Cargar preferencias si existen
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f);
        difficultyDropdown.value = PlayerPrefs.GetInt("Difficulty", 0);
        musicSource.volume = volumeSlider.value;

        // Listeners
        volumeSlider.onValueChanged.AddListener(UpdateVolume);
        difficultyDropdown.onValueChanged.AddListener(UpdateDifficulty);
    }

    void UpdateVolume(float value)
    {
        musicSource.volume = value;
        PlayerPrefs.SetFloat("Volume", value);
        volumeLevel = value;
    }

    void UpdateDifficulty(int index)
    {
        PlayerPrefs.SetInt("Difficulty", index);
        difficultyIndex = index;
    }

    public void StartGame()
    {
        playerName = nameInput.text;
        SceneManager.LoadScene("NombreDeTuEscenaDeJuego");
    }
}
