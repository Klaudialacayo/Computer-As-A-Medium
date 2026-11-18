using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 50;
    void Start()
    {

    }

    void Update()
    {
        Death();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sword"))
        {
            enemyHealth -= 10;
        }
    }
    void Death()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
