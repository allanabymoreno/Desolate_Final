using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    public scrAudioGame sfxGame;
    public GameObject celular;
    public GameObject luz;

    public MeshRenderer mesh;

    public void Update()
    {
        lanterna();
    }
    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            sfxGame.fxSonoros[0].Play();
            celular.SetActive(false);
            //mesh.enabled = false;
            
        }
    }

    public void lanterna()
   {
      if (Input.GetKeyDown(KeyCode.F))
      {
         luz.SetActive(!luz.activeSelf);
         sfxGame.fxSonoros[4].Play();
      }
   }
    
   
}
