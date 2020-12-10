using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook1st : MonoBehaviour
{
    public bool podeOlhar=true;
    public float mouseSentivity = 100f;
    public Transform PlayerBody;
    public Transform Target;

    public float smoothSpeed = 0.125f;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(podeOlhar){
            float mouseX = Input.GetAxis("Mouse X")* mouseSentivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y")* mouseSentivity * Time.deltaTime;

            xRotation-=mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f,0f);
            PlayerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
