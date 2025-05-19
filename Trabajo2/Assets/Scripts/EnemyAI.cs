using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;
    public AudioSource collisionSound;
    public ParticleSystem hitEffect;

    void Start()
    {
        int dificultad = PlayerPrefs.GetInt("Dificultad", 0);
        float velocidad = 3f;

        switch (dificultad)
        {
            case 0: velocidad = 3f; break;
            case 1: velocidad = 6f; break;
            case 2: velocidad = 9f; break;
        }

        agent.speed = velocidad;
    }

    void Update()
    {
        if (agent != null && player != null)
        {
            agent.SetDestination(player.position);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colisión con el jugador");

            if (collisionSound != null)
            {
                collisionSound.Play();
                Debug.Log("Reproduciendo sonido de colisión");
            }

            if (hitEffect != null)
            {
                hitEffect.transform.position = collision.contacts[0].point;
                hitEffect.Play();
            }
        }
    }
}

