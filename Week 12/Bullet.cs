using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy == null)
        {
            return;
        }

        enemy.enemyHealth -= damage;

        Debug.Log("Enemy health after bullet: " + enemy.enemyHealth);

        Destroy(gameObject);
    }
}
