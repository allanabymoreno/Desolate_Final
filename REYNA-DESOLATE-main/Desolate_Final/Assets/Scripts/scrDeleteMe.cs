using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrDeleteMe : MonoBehaviour
{
    public scrAudioGame sfxGame;
    public GameObject celular;
    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            sfxGame.fxSonoros[0].Play();
            celular.SetActive(false);
            
        }
    }
}
