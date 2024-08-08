using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public static EnemyHealth Instance;

    [SerializeField] int health;
    public int maxHealth;

    [SerializeField] GameObject father;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int dano)
    {
        health -= dano;
        Robot.Instance.TakeDamage(dano);
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
