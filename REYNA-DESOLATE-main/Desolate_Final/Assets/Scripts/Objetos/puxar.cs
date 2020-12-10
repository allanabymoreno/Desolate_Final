using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puxar : MonoBehaviour { 

    public float x;
    public float y;
    public float z;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddForce(x, y, z, ForceMode.Impulse);
        }
        
    }


}
