using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        InvokeRepeating("UpdateEnemyMovement", 1f, 1f);  // Actualiza cada 1 segundo
    }

    void UpdateEnemyMovement()
    {
        if (player != null)
        {
            agent.SetDestination(player.position);  // Enemigo sigue al jugador
        }
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Cuando el enemigo toque al jugador, lo desactiva
            collision.gameObject.GetComponent<PlayerController>().DeactivatePlayer();
        }
    }*/
    private void Update()
    {
        UpdateEnemyMovement();
    }
}
