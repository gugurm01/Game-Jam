using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public static PlayerLife instance;

    [SerializeField] int vidas;
    [SerializeField] int maxVidas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        vidas = maxVidas;
    }

    void Update()
    {
        
    }

    public void TakeDamage(int dano)
    {
        vidas-=dano;
        if(vidas <= 0)
        {
            Debug.Log("morreu");
        }
    }
}
