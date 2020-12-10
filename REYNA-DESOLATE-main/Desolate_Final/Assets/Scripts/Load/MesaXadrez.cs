using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;


public class MesaXadrez : MonoBehaviour
{
    bool unload;
    bool Active = true;

    
    public GameObject mesa1;
    public GameObject mesa2;
    public GameObject Player;
    private GerenciadorCena puzzleConcluido;

    private void Start()
    {
        puzzleConcluido = GameObject.FindGameObjectWithTag("Interact").GetComponent<GerenciadorCena>();
    }

   
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Active == true)
                {
                    
                    Travar();
                  

                }
                else
                {
                    Destravar();
                }
                Active = !Active;

            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Destravar();
            }

           
        }


        void Travar()
        {
            Player.GetComponent<PlayerMovement>().enabled = false;
            unload = true;
            SceneManager.LoadSceneAsync("Xadrez", LoadSceneMode.Additive);
            
        }
        void Destravar()
        {
            SceneManager.UnloadSceneAsync("Xadrez");
            
            unload = false;
            Player.GetComponent<PlayerMovement>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            if (puzzleConcluido.puzzleConcluido == true)
            {
                
                mesa1.SetActive(false);
                mesa2.SetActive(true);
            }
        }

       


    }
}

