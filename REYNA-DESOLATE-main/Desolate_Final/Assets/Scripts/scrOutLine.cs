using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrOutLine : MonoBehaviour
{
    public GameObject outlineOBJ;
    
    void OnTriggerEnter(Collider quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            outlineOBJ.SetActive(true);
        }
    }
    void OnTriggerExit(Collider quem)
    {
        if (quem.gameObject.tag == "Player")
        {
            outlineOBJ.SetActive(false);
        }
    }
}
