using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCheckMe : MonoBehaviour
{
    public Inventory scrInventory;

    void Start(){
        scrInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        DesJarrado();
    }

    void Update(){
        if(scrInventory.hasJarro == true){
             for (int i = 0; i < scrInventory.slots.Length; i++)
            {
             if(scrInventory.isFull[i] == true){
                    scrInventory.isFull[i] = false;
                    Destroy(gameObject);
                    break;
                }
            }
        }  
    }

    public void DesJarrado(){
        scrInventory.hasJarro = true;
    }
}
