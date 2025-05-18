using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    private Renderer playerRenderer;

    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    public void DeactivatePlayer()
    {
        // Cambiar el color a gris
        playerRenderer.material.color = Color.gray;

        // Detener movimiento del jugador
        controller.enabled = false;
    }
}
