using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PecaXadrez : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(-0.25f, 0, 0 * Time.deltaTime));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0.25f, 0, 0 * Time.deltaTime));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -0 * Time.deltaTime, -1));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 1));
        }
    }

}
