using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
private Inventory inventory;
public GameObject  itembutton;
public scrAudioGame sfxGame;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
  void OnTriggerStay(Collider other)
  {
      if(Input.GetKeyUp(KeyCode.E)){
      if(other.CompareTag("Player")){
      
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == false){
                    sfxGame.fxSonoros[0].Play();
                    inventory.isFull[i] = true;
                    Instantiate(itembutton,inventory.slots[i].transform,false);
                    Destroy(gameObject);
                    break;
                    }
                }
          }  
      }   
      }
  }

