using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Robot : MonoBehaviour
{
    public static Robot Instance;

    public Image healthBar;
    public float healthBarAmount = 100f;

    [SerializeField] int vidas;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        print(vidas);
    }

    public void TakeDamage(int dano)
    {
        vidas -= dano;
        healthBarAmount -= dano;
        healthBar.fillAmount = healthBarAmount / 100f;
        if (vidas <= 0)
        {
            GameManager.Instance.Win();
        }
    }
}
