using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int maxHealth;

    [SerializeField] GameObject father;

    [SerializeField] TextMeshProUGUI healthText;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        healthText.text = health.ToString("Vida do Inimigo: 0");
    }

    public void TakeDamage(int dano)
    {
        health -= dano;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(father);
    }
}
