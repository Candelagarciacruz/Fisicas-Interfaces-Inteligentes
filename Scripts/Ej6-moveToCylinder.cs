using UnityEngine;

public class moveToCylinder : MonoBehaviour
{
    public Transform cylinder;
    public Transform cube;
    public Material newMaterial;
    public float speed = 2f;
    public float collisionDistante = 1f;
    private bool changedCube = false;

    void Update()
    {
        Vector3 directionVector = (cylinder.position - transform.position).normalized;
        transform.position += directionVector * speed * Time.deltaTime;
        if (!changedCube) {
            float distanceVector = Vector3.Distance(transform.position, cube.position);
            if (distanceVector < collisionDistante) {
                ChangeMaterial();
            }
        }
    }

    void ChangeMaterial() 
    {
        Renderer rd = cube.GetComponent<Renderer>();
        rd.material = newMaterial;
        changedCube = true;
    }
}
