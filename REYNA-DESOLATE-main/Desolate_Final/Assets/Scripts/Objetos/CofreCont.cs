using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CofreCont : MonoBehaviour
{
    public Camera cam;
    public LayerMask botao1;
    public LayerMask botao2;
    public LayerMask botao7;
    public LayerMask botao9;
    public LayerMask botaoerrado;
    public GameObject portaCofre;
    private GameObject Cofre;
    public GerenciadorCena gen;
    private int cont;

    private void Start()
    {
        gen = GameObject.FindGameObjectWithTag("Interact").GetComponent<GerenciadorCena>();
    }

    void Update()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(cont == 0)
        {
            if (Physics.Raycast(ray, out hit, 100, botao1))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    cont++;
                    print("BOTAO 1");
                    print(cont);
                }
            }
        }

        if(cont == 0 || cont == 2 || cont == 3 || cont == 4)
        {
            if (Physics.Raycast(ray, out hit, 100, botao7))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    cont = 0;
                    print(cont);
                }
            }

        }

        if(cont == 0 || cont == 1 || cont == 3 || cont == 4)
        {
            if(Physics.Raycast(ray, out hit, 100, botao9))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    cont = 0;
                    print(cont);
                }
            }
        }

        if (cont == 0 || cont == 1 || cont == 2)
        {
            if (Physics.Raycast(ray, out hit, 100, botao2))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    cont = 0;
                    print(cont);
                }
            }
        }


        if (cont == 1)
        {
            if (Physics.Raycast(ray, out hit, 100, botao7))
            {
                if (Input.GetMouseButtonDown(0))
                {
                   cont++;
                   print("BOTAO 7");
                   print(cont);
                    
                }
            }

        }
       
        if (cont == 2)
        {
            if (Physics.Raycast(ray, out hit, 100, botao9))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    cont++;
                    print("BOTAO 9");
                    print(cont);
                }
            }

        }
        if(cont== 3)
        {
            if (Physics.Raycast(ray, out hit, 100, botao2))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    cont++;
                    if(cont == 4)
                    {
                        print("BOTAO 2");
                        print(cont);
                        portaCofre.transform.localRotation = Quaternion.Euler(0, -90f, 0);
                        gen.puzzleConcluido = true;
                        

                    }
                }
            }
        }
        if(Physics.Raycast(ray, out hit, 100, botaoerrado))
        {
            if (Input.GetMouseButtonDown(0))
            {
                cont = 0;
                print("Senha Invalida");
                print(cont);
            }
        }

    }
}
