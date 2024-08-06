
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider musicaSlider;
    [SerializeField] private Slider efeitosSlider;

    public void Start()
    {
        if (PlayerPrefs.HasKey("Música"))
        {
            LoadVolume();
        }
        else
        {
            SetVolumeMusica();
            SetVolumeEfeitos();

        }

    }
    public void SetVolumeMusica()
    {
        float volume = musicaSlider.value;
        mixer.SetFloat("Música", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("Música", volume);
    }
    public void SetVolumeEfeitos()
    {
          float volume = efeitosSlider.value;
          mixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
          PlayerPrefs.SetFloat("SFX", volume);
    }

    public void LoadVolume()
    {
        musicaSlider.value = PlayerPrefs.GetFloat("Música");
        efeitosSlider.value = PlayerPrefs.GetFloat("SFX");      

        SetVolumeMusica();
        SetVolumeEfeitos();     
    }



}
