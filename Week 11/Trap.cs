using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trap touched by: " + other.name);

        if (!other.CompareTag("Player"))
        {
            Debug.Log("This object does not have the Player tag.");
            return;
        }

        if (playerHealth == null)
        {
            Debug.LogError("Assign Player Health on the trap.");
            return;
        }

        playerHealth.health -= 10;
        Debug.Log("Health after trap: " + playerHealth.health);
    }
}