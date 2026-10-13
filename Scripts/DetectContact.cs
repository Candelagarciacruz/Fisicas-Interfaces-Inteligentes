using UnityEngine;

public class DetectContact : MonoBehaviour
{
    // Is called when the Collider other enters the trigger.
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " ha interactuado con " + other.gameObject.name);
    }
}
