using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Estante : MonoBehaviour
{
    bool unload;
    bool Active = true;

    public GameObject estante;
    public GameObject estante1;
    public GameObject Player;
    private GerenciadorCena estanteConcluida;

    private void Start()
    {
        estanteConcluida = GameObject.FindGameObjectWithTag("Interact").GetComponent<GerenciadorCena>();
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




            void Travar()
            {
                Player.GetComponent<PlayerMovement>().enabled = false;
                unload = true;
                SceneManager.LoadSceneAsync("Estante", LoadSceneMode.Additive);

            }
            void Destravar()
            {
                SceneManager.UnloadSceneAsync("Estante");

                unload = false;
                Player.GetComponent<PlayerMovement>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                if (estanteConcluida.estanteConcluida == true)
                {

                    estante.SetActive(false);
                    estante1.SetActive(true);
                }
            }




        }
    }
}
