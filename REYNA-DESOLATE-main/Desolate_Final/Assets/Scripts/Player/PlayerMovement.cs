using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool possoMover=true;
    public Transform player;

    public Transform playerC;
    public Animator animator;
    public CharacterController controller;
    public float speed = 20f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Camera mainCamera;
    
    void Update()//Movimentacao
    {
        if(possoMover){
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            animator.SetFloat("Speed", (x+z));
            Vector3 move = transform.right * x + transform.forward * z; 
            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
            // AGACHAR
            if(Input.GetKeyDown(KeyCode.LeftControl)){
                speed = 10f;
                Cursor.lockState = CursorLockMode.None;
                animator.SetBool("Crouch",true);
            }if(Input.GetKeyUp(KeyCode.LeftControl)){
                Cursor.lockState = CursorLockMode.Locked;
                animator.SetBool("Crouch",false);
                speed = 10f;
            }if(Input.GetKeyDown(KeyCode.LeftShift)){
                speed = 40;
            }if(Input.GetKeyUp(KeyCode.LeftShift)){
                speed = 20;
            }
        }
       }
       void LateUpdate()
       {
           if(possoMover){
                if(Input.GetKeyDown(KeyCode.LeftControl))
                {
                mainCamera.transform.position = new Vector3(playerC.position.x,playerC.position.y,playerC.position.z);
                }
                if(Input.GetKeyUp(KeyCode.LeftControl))
                {
                mainCamera.transform.position = new Vector3(player.position.x,player.position.y,player.position.z);
                }
           }
       }

    }
