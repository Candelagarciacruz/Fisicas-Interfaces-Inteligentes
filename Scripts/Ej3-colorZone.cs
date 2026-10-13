using UnityEngine;

public class colorZone : MonoBehaviour
{
    // Is called when the Collider other enters the trigger.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            Renderer rdPlayer = other.GetComponent<Renderer>();

            if (rdPlayer != null) {
                rdPlayer.material.color = Color.blue;
            }
        }
    }

    // Is called when the Collider other exits the trigger.
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) {
            Renderer rdPlayer = other.GetComponent<Renderer>();

            if (rdPlayer != null) {
                rdPlayer.material.color = Color.grey;
            }
        }
    }
}
