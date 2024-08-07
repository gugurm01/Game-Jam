using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public static PlayerLife instance;

    public int maxHealth = 100;
    public int currentHealth;
    public bool isImmobilized = false;

    public Transform revivePoint; // Localização onde o jogador será revivido
    public float immobilizeTime = 30f; // Tempo máximo para ser revivido
    public Slider immobilizeProgressBar;

    public GameObject player;

    private float immobilizeTimer;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentHealth = maxHealth;
        immobilizeProgressBar.maxValue = immobilizeTime;
    }

    void Update()
    {
        if (isImmobilized)
        {
            immobilizeTimer -= Time.deltaTime;
            immobilizeProgressBar.value = immobilizeTime - immobilizeTimer;

            if (immobilizeTimer <= 0)
            {
                Die();
            }
        }
    }

    public void TakeDamage(int damage)
    {
        if (isImmobilized) return;

        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Immobilize();
        }
    }

    void Immobilize()
    {
        isImmobilized = true;
        immobilizeTimer = immobilizeTime;
        immobilizeProgressBar.gameObject.SetActive(true);
        player.GetComponent<Player>().enabled = false;
    }

    public void Revive()
    {
        if (!isImmobilized) return;

        isImmobilized = false;
        immobilizeProgressBar.gameObject.SetActive(false);
        currentHealth = maxHealth;
        transform.position = revivePoint.position;
        player.GetComponent<Player>().enabled = true;
    }

    void Die()
    {
        isImmobilized = false;
        immobilizeProgressBar.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
