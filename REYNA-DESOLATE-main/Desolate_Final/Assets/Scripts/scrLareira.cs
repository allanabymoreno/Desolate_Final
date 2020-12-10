using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrLareira : MonoBehaviour
{
    public GameObject fxFire;
    public Inventory scrInventory;

    void Start(){
        scrInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void Update(){
        if(scrInventory.hasJarro == true && Input.GetKeyDown(KeyCode.E)){
             fxFire.SetActive(false);
        }  
    }

}
