using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    GameObject[] enemies;

    public GameObject hudPanel, gameOverPanel; 

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if(enemies.Length <= 0)
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
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
