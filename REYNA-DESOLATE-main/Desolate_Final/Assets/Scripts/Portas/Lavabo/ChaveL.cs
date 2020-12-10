using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveL : MonoBehaviour
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
        if(inventory.HasKeyLUsed == true){
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
        inventory.HasKeyL = true;
    }
}