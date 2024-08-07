using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reviving : MonoBehaviour
{
    public float reviveRange = 5f; // Distância para poder reviver
    public float reviveTime = 5f; // Tempo necessário para reviver
    public Slider reviveProgressBar; // Barra de progresso do processo de revivificação

    private float reviveTimer = 0f;
    private bool isReviving = false;
    [SerializeField] private PlayerLife playerToRevive;

    [SerializeField] string key;

    void Update()
    {
        if (isReviving)
        {
            reviveTimer -= Time.deltaTime;
            reviveProgressBar.value = reviveTime - reviveTimer;

            if (reviveTimer <= 0)
            {
                CompleteRevive();
            }
        }
        else if (Input.GetButtonDown(key)) // Pressione "R" para tentar reviver
        {
            TryRevive();
        }
    }

    void TryRevive()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, reviveRange);
        foreach (var hitCollider in hitColliders)
        {
            PlayerLife player = hitCollider.GetComponent<PlayerLife>();
            if (player != null && player != this && player.isImmobilized)
            {
                playerToRevive = player;
                isReviving = true;
                reviveTimer = reviveTime;
                reviveProgressBar.gameObject.SetActive(true);
                break;
            }
        }
    }

    void CompleteRevive()
    {
        if (playerToRevive != null)
        {
            playerToRevive.Revive();
            isReviving = false;
            reviveProgressBar.gameObject.SetActive(false);
        }
    }
}
