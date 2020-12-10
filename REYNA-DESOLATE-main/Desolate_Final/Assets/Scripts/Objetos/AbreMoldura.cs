using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreMoldura : MonoBehaviour
{
    bool abrirMoldura;
    public bool molduraTrancada;
    
    public GameObject cofre;
    private Inventory inventory;
    private AbreMoldura moldura;
    private PortaDestrancada molduraDestrancada;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        abrirMoldura = false;
        moldura = GetComponent<AbreMoldura>();
        molduraDestrancada = GetComponent<PortaDestrancada>();
    }


    void Update()
    {
        if (Input.GetKeyUp("e"))
        {
            if (abrirMoldura == true)
            {
                if (molduraTrancada == true)
                {
                    inventory.HasKeyI = false;
                    inventory.HasKeyIUsed = true;
                    moldura.enabled = true;
                    molduraDestrancada.enabled = true;
                    cofre.SetActive(false);
                }
                transform.position = new Vector3(-7.7f, 59f, 40f);
                cofre.SetActive(true);

               
            }
            
        }
        
        
    }

    public void OnTriggerStay()
    {
        abrirMoldura = true;
        molduraTrancada = !inventory.HasKeyI;
    }

    public void OnTriggerExit()
    {
        molduraTrancada = inventory.HasKeyI;
        abrirMoldura = false; 
    }
    

    
}
