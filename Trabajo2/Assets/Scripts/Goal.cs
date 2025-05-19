using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    public GameTimer gameTimer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            if (gameTimer == null)
            {
                Debug.LogError("GameTimer no está asignado al script Goal.");
                return;
            }

            gameTimer.StopTimer();

            float tiempoFinal = gameTimer.GetElapsedTime();
            PlayerPrefs.SetFloat("TiempoFinal", tiempoFinal);

            string nombreJugador = PlayerPrefs.GetString("Nombre", "Jugador");
            PlayerPrefs.SetString("NombreJugadorFinal", nombreJugador);

            SceneManager.LoadScene("FinDelJuego");
        }
    }
}
