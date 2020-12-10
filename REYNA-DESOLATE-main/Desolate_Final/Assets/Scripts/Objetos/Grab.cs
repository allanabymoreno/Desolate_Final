using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public Transform hand;

    void Start()
    {
        //Set Cursor to not be visible
        
    }
    void OnMouseDown()
    {
        GetComponent<Collider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = hand.position;
        this.transform.parent = GameObject.Find("hand").transform;
    }

    // Use this for initialization
    

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Collider>().enabled = true;

    }


}
