using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject objectToSwap;
    public GameObject newObject;
    public float powerUpDuration = 5f; // Duração do power-up em segundos

    private GameObject originalObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            ActivatePowerUp();
        }
    }

    

    private void ActivatePowerUp()
    {
        if (objectToSwap != null && newObject != null)
        {
            objectToSwap.SetActive(false);

            // Ativa o novo objeto
            newObject.SetActive(true);

            // Inicia a contagem regressiva para reverter o power-up
            StartCoroutine(DeactivatePowerUpAfterDelay(powerUpDuration));
        }
    }

    private IEnumerator DeactivatePowerUpAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (objectToSwap != null)
        {
            // Ativa o objeto original
            objectToSwap.SetActive(true);
        }

        if (newObject != null)
        {
            // Desativa o novo objeto
            newObject.SetActive(false);
        }
    }
}
