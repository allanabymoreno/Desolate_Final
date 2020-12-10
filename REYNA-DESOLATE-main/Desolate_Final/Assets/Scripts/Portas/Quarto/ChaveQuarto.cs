using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveQuarto : MonoBehaviour
{
    public bool destrancada;
    public Inventory inventory;
    public bool Usada = false;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        Destrancada();

    }
 
    void Update()
    {
        if(inventory.HasKeyRUsed == true){
             for (int i = 0; i < inventory.slots.Length; i++)
            {
             if(inventory.isFull[i] == true){
                    inventory.isFull[i] = false;
                    Destroy(gameObject);
                    break;
                    }
            }
        }  
    }
    public void Destrancada(){
        inventory.HasKeyR = true;
    }

}