using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageInLantern : MonoBehaviour
{
    public int damageAmount = 1;
    public float damageInterval = 0.1f;

    private bool isInsideTrigger = false;
    private bool isTakingDamage = false;

    private EnemyHealth health;

    void Start()
    {
        health = GetComponent<EnemyHealth>();

        if (health == null)
        {
            Debug.LogError("O componente de Health não encontrado!");
        }
    }

    void Update()
    {
        if (isInsideTrigger && !isTakingDamage)
        {
            StartTakingDamage();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lanterna"))
        {
            isInsideTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Lanterna"))
        {
            isInsideTrigger = false;
            StopTakingDamage();
        }
    }

    private void StartTakingDamage()
    {
        if (!isTakingDamage)
        {
            isTakingDamage = true;
            StartCoroutine(DamageCoroutine());
        }
    }

    private void StopTakingDamage()
    {
        if (isTakingDamage)
        {
            isTakingDamage = false;
            StopCoroutine(DamageCoroutine());
        }
    }

    private IEnumerator DamageCoroutine()
    {
        while (isTakingDamage)
        {
            if (health != null)
            {
                health.TakeDamage(damageAmount);
            }

            yield return new WaitForSeconds(damageInterval);
        }
    }
}
