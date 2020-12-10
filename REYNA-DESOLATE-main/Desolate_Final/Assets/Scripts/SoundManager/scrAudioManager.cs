using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scrAudioManager : MonoBehaviour{
    public AudioSource musicas;
    private AudioSource fxSonoros;

    private float musicVolume = 1f;

    private void Start()
    {
        musicas = GetComponent<AudioSource>();
    }

    private void Update()
    {
        musicas.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
