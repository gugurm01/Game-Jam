using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transicao : MonoBehaviour
{
    private void Start()
    {
        
    }

    public string nomeDaProximaCena; // Nome da cena que voc� deseja carregar

    
    public void CarregarProximaCena()
    {
        SceneManager.LoadScene(nomeDaProximaCena);
    }
}

