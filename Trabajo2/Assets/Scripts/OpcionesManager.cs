using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OpcionesManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Dropdown difficultyDropdown;
    public Slider volumeSlider;

    public void VolverAlMenu()
    {
        // Guarda los valores seleccionados
        PlayerPrefs.SetString("Nombre", nameInput.text);
        PlayerPrefs.SetInt("Dificultad", difficultyDropdown.value);
        PlayerPrefs.SetFloat("Volumen", volumeSlider.value);
        PlayerPrefs.Save();

        // Regresar al menú principal (ajusta el nombre si tu escena se llama distinto)
        SceneManager.LoadScene("MenuPrincipal");
    }
}
