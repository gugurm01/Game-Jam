using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject menuPausa;
    [SerializeField] private GameObject menuControles;
    [SerializeField] private GameObject menuAudio;

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


    public void AtivarMenuAudio()
    {
        menuAudio.SetActive(true);

    }

    public void SairJogo()
    {
        Application.Quit();
    }
}