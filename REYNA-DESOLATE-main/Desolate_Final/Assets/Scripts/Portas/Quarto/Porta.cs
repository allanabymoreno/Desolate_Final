
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Porta : MonoBehaviour
{
    public scrAudioGame sfxGame;
    bool abrirPorta;
    bool fecharPorta;
    public bool portaTrancada;
    public GameObject CanvasObject;
    public Vector3 rotacao = new Vector3(0, 0, 0);
    private Inventory inventory;
    private Porta porta;
   private PortaDestrancada portaDestrancada;
    
    void Start()
    {
        inventory =  GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        abrirPorta = false;
        fecharPorta = true;
        porta = GetComponent<Porta>();
        portaDestrancada = GetComponent<PortaDestrancada>();
    }

    
    void Update()
    {
        if (Input.GetKeyUp("e"))
        {
            if(abrirPorta == true)
            {
                if (portaTrancada == true)
                {
                    sfxGame.fxSonoros[1].pitch = (Random.Range(0.6f,.9f));
                    sfxGame.fxSonoros[1].Play();
                    //CanvasObject.SetActive(true);
                } 

                if(portaTrancada == false)
                {
                    sfxGame.fxSonoros[3].Play();
                    fecharPorta = !fecharPorta;
                    inventory.HasKeyR = false;
                    inventory.HasKeyRUsed = true;
                    porta.enabled = false;
                    portaDestrancada.enabled = true;
                    
                }    
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

    void DisableCanvas()
    {
       // CanvasObject.SetActive(false);
    }
    

    public void OnTriggerStay()
    {
         abrirPorta = true;
         portaTrancada = !inventory.HasKeyR;
    }

    public void OnTriggerExit()
    {
          portaTrancada = inventory.HasKeyR;
          abrirPorta = false;
          DisableCanvas();
            
    }
}