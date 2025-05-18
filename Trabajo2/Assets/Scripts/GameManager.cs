using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public TMP_Text infoText;
    public AudioSource musicSource;

    void Start()
    {
        string name = MenuManager.playerName;
        int difficulty = MenuManager.difficultyIndex;
        float volume = MenuManager.volumeLevel;

        musicSource.volume = volume;

        string difficultyText = difficulty == 0 ? "Fácil" : difficulty == 1 ? "Medio" : "Difícil";
        infoText.text = $"Jugador: {name} | Dificultad: {difficultyText}";
    }

}
