using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Robot : MonoBehaviour
{
    public static Robot Instance;

    public Slider healthSlider;
    public float healthBarAmount = 100f;

    [SerializeField] public int vidas, maxHealth;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        vidas = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = vidas;
    }

    public void TakeDamage(int dano)
    {
        vidas -= dano;
        healthSlider.value = vidas;
        if (vidas <= 0)
        {
            Debug.Log("Ganhou");
        }
    }
}
