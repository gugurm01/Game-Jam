using UnityEngine;

public class Setas : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento do objeto

    void Update()
    {
        // Captura a entrada vertical (setas para cima/baixo ou W/S)
        float verticalInput = Input.GetAxis("Vertical 1");

        // Move o objeto para frente ou para trás com base na entrada
        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
    }
}
