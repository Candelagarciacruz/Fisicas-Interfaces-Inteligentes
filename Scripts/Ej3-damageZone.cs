using UnityEngine;

public class damageZone : MonoBehaviour
{
    // Is called when the Collider other enters the trigger.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            playerDamage player = other.GetComponent<playerDamage>();

            if (player != null) {
                player.damage += 1;
                Debug.Log("Daño acumulado: " + player.damage);
            }
        }
    }
}
