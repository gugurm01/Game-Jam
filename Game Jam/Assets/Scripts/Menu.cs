using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] private string cenaDoJogo;

    public void Jogar()
    {
        SceneManager.LoadScene(cenaDoJogo);
    }
    public void SairJogo()
    {
        Application.Quit();
    }


}