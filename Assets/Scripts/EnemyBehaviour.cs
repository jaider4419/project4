using System.Collections;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed = 2.0f;
    private Transform playerTransform;
    private bool isActive = false;

    void Start()
    {
        // Start the coroutine to activate the enemy after 5 seconds
        StartCoroutine(ActivateEnemy());
    }

    IEnumerator ActivateEnemy()
    {
        // Wait for 5 seconds
        yield return new WaitForSeconds(5.0f);

        // Activate the enemy
        isActive = true;
    }

    void Update()
    {
        if (isActive)
        {
            // Find the player GameObject if not already found
            if (playerTransform == null)
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                if (player != null)
                {
                    playerTransform = player.transform;
                }
            }

            // Move towards the player
            if (playerTransform != null)
            {
                Vector3 direction = playerTransform.position - transform.position;
                direction.Normalize();

                transform.position += direction * speed * Time.deltaTime;
            }
        }
    }
}
