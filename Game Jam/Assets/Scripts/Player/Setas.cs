using UnityEngine;

public class Setas : MonoBehaviour
{
    public float moveSpeed = 5f; 

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical 1");
        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
    }
}
