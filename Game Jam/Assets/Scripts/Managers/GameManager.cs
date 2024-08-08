using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    GameObject[] enemies;
    [SerializeField] GameObject player1, player2;

    public GameObject hudPanel, gameOverPanel, winPanel; 

    private void Awake()
    {
        Time.timeScale = 0;
        Instance = this;
    }

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if(player1.GetComponent<PlayerLife>().isImmobilized && player2.GetComponent<PlayerLife>().isImmobilized)
        {
            GameOver();
        }

        if(Robot.Instance.vidas <= 0)
        {
            Win();
        }
    }

    public void GameOver()
    {
        hudPanel.SetActive(false);
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Win()
    {
        hudPanel.SetActive(false);
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
