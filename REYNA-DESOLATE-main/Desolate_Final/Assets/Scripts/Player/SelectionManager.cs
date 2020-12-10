using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public Camera cam;
    public LayerMask MovementChadrez1;
    public LayerMask MovementChadrez2;
    public LayerMask MovementChadrez3;
    public LayerMask MovementChadrez4;
    public LayerMask Tabuleiro;
    public GameObject Cavalo;
    public GameObject Peao1;
    public bool passo1 = false;
    public GameObject Peao2;
     public bool passo2 = false;
    public GameObject Peao3;
     public bool passo3 = false;
    public GameObject Rainha;
    public Transform gaveta;
    private GameObject Chess1;
    public GerenciadorCena gen;
    void Update()
    {
        PuzzleConcluido();
        gen = GameObject.FindGameObjectWithTag("Interact").GetComponent<GerenciadorCena>();
    }

    public void PuzzleConcluido()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (passo1 == false)
        {
            if (Physics.Raycast(ray, out hit, 100, MovementChadrez1))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (passo1 == false)
                    {
                        Destroy(Peao1);
                        Cavalo.transform.position = new Vector3(-56.5f, 73.35654f, 1540.38f);
                        Debug.Log("Ok, Entao talvez eu deva...dar um cheque mate?");
                        passo1 = true;
                    }
                }
            }
        }
        if (passo1 == true)
        {
            if (Physics.Raycast(ray, out hit, 100, MovementChadrez2))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (passo1 == true)
                    {
                        Destroy(Peao2);
                        Cavalo.transform.position = new Vector3(-58.07f, 73.35654f, 1540.99f);
                        Debug.Log("falta mais uma jogada...");
                        passo2 = true;
                    }
                }
            }
        }
        if (passo2 == true)
        {
            if (Physics.Raycast(ray, out hit, 100, MovementChadrez3))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(Peao3);
                    Cavalo.transform.position = new Vector3(-57.17f, 73.35654f, 1539.48f);
                    passo3 = true;
                }
            }
        }
        if (passo3 == true)
        {
            if (Physics.Raycast(ray, out hit, 100, MovementChadrez4))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(Rainha);
                    Cavalo.transform.position = new Vector3(-58.71f, 73.35654f, 1538.64f);
                    Debug.Log("Isso, Chequemate");
                    gaveta.transform.position = new Vector3(-65.27f, 73.51247f, 1538.352f);
                    Debug.Log("Opa, uma gaveta abriu");
                    gen.puzzleConcluido = true;
                }
            }
        }
      

    }

   

}