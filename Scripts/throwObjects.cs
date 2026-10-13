using UnityEngine;

public class throwObjects : MonoBehaviour
{
    public float force;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) {
            rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
        }
    }
}
