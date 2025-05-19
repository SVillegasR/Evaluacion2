using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{
    private int collisionCount = 0;
    private float originalSpeed;
    private NavMeshAgent agent;
    private bool isSlowed = false;
    private bool isGameOverTriggered = false;
    private bool canCollide = true;

    public AudioSource collisionSound;
    public ParticleSystem hitEffect;
    public float slowDuration = 3f;
    public ParticleSystem hitEffectPrefab;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            originalSpeed = agent.speed;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador") && canCollide && !isGameOverTriggered)
        {
            canCollide = false; // Evita múltiples colisiones seguidas
            collisionCount++;

            if (collisionCount == 1)
            {
                if (!isSlowed)
                    StartCoroutine(SlowDownTemporarily());

                if (collisionSound != null)
                    collisionSound.Play();

                if (hitEffect != null)
                    hitEffect.Play();

                StartCoroutine(ResetCollisionCooldown());
            }
            else if (collisionCount >= 2)
            {
                isGameOverTriggered = true;

                if (collisionSound != null)
                    collisionSound.Play();

                if (hitEffect != null)
                    hitEffect.Play();

                StartCoroutine(TriggerGameOver());
            }
        }
    }

    IEnumerator ResetCollisionCooldown()
    {
        yield return new WaitForSeconds(1f); // tiempo entre colisiones
        canCollide = true;
    }

    IEnumerator SlowDownTemporarily()
    {
        isSlowed = true;
        if (agent != null)
            agent.speed *= 0.5f;

        yield return new WaitForSeconds(slowDuration);

        if (agent != null)
            agent.speed = originalSpeed;

        isSlowed = false;
    }

    IEnumerator TriggerGameOver()
    {
        yield return new WaitForSeconds(1f); // Espera para ver partículas/audio
        SceneManager.LoadScene("GameOver");
        Destroy(gameObject);
    }
}

