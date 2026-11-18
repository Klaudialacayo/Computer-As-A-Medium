using UnityEngine; using System.Collections;

public class SpeedBoost : MonoBehaviour { public float boostAmount = 1f; public float boostDuration = 1f;

private void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();

        if (player != null)
        {
            StartCoroutine(BoostSpeed(player));

            // Make the speed boost object disappear immediately
            Destroy(gameObject);
        }
    }
}

IEnumerator BoostSpeed(PlayerMovement player)
{
    float originalSpeed = player.moveSpeed;

    player.moveSpeed += boostAmount;

    yield return new WaitForSeconds(boostDuration);

    player.moveSpeed = originalSpeed;
}
