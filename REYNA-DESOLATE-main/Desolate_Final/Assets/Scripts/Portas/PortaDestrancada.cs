using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortaDestrancada : MonoBehaviour
{
    public scrAudioGame sfxGame;
    bool abrirPorta;
    bool fecharPorta;
    public Vector3 rotacao = new Vector3(0, 0, 0);
    
    void Start()
    {
        abrirPorta = false;
        fecharPorta = true;
    }

    
    void Update()
    {
        if (Input.GetKeyUp("e")){
            if(abrirPorta == true)
            {
                sfxGame.fxSonoros[2].pitch = (Random.Range(0.6f,.9f));
                sfxGame.fxSonoros[2].Play();
                fecharPorta = !fecharPorta;    
            }
        }
        if(fecharPorta == true)
        {
            Vector3 rotacao1 = new Vector3(0, 0, 0);
            transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, rotacao1, Time.deltaTime);
            
            
        }
        else
        {
            transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, rotacao, Time.deltaTime);    
        }
    }
    
    void OnTriggerStay(Collider other)
    {
        if( other.gameObject.CompareTag("Player")){
            abrirPorta = true;
        }
    }

    public void OnTriggerExit()
    {
          abrirPorta = false;
            
    }
}
