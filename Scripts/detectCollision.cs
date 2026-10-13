using UnityEngine;

public class detectCollision : MonoBehaviour
{
    private Renderer rd;

    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // It happens when physical contact with another object begins.
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " ha colisionado con " + collision.gameObject.name);
        rd.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
