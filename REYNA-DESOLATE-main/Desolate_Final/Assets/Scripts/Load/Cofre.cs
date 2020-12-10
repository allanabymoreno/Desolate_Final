using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;


public class Cofre : MonoBehaviour
{

    bool unload;
    bool Active = true;

    public GameObject cofre1;
    public GameObject cofre2;
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
            SceneManager.LoadSceneAsync("Cofre", LoadSceneMode.Additive);
            
        }
        void Destravar()
        {
            SceneManager.UnloadSceneAsync("Cofre");
            
            unload = false;
            Player.GetComponent<PlayerMovement>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            if (puzzleConcluido.puzzleConcluido == true)
            {

                cofre1.SetActive(false);
                cofre2.SetActive(true);
            }
        }




    }
}