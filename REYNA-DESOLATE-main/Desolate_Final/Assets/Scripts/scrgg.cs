using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrgg : MonoBehaviour
{
    public GameObject canvasGG;
    public bool temChave = false;
    public GameObject GG;
    public GameObject chaveFinal;

    void Update(){
        if(chaveFinal.activeSelf){
            GG.GetComponent<Collider>().enabled = true;
            temChave = true;
        }else{
            temChave = false;
        }
    }

    void OnTriggerEnter(Collider quem){
        if(quem.gameObject.tag == "Player"){
            if(temChave == true){
                Time.timeScale = 0.00001f;
                canvasGG.SetActive(true);
            }
        }
    }
}
