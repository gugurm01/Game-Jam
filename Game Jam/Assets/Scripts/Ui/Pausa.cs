using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject menuPausa;
    [SerializeField] private GameObject menuControles;
    [SerializeField] private GameObject menuAudio;
    [SerializeField] private GameObject menuTuto;

    void Update()
    {

        if (Input.GetButtonDown("Cancel") && !menuPausa.activeSelf && !menuControles.activeSelf && !menuAudio.activeSelf)
        {
            menuPausa.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }

        else if (Input.GetButtonDown("Cancel") && menuPausa.activeSelf)
        {
            menuPausa.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }


    public void AtivarMenuControles()
    {
        menuControles.SetActive(true);

    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void VoltarProMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AtivarMenuAudio()
    {
        menuAudio.SetActive(true);

    }

    public void SairJogo()
    {
        Application.Quit();
    }

    public void SairTuto()
    {
        Time.timeScale = 1;
        menuTuto.SetActive(false);
    }
}