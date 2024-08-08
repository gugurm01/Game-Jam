using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transicao : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public string nomeDaProximaCena; // Nome da cena que você deseja carregar

    
    public void CarregarProximaCena()
    {
        SceneManager.LoadScene(nomeDaProximaCena);
    }
}

