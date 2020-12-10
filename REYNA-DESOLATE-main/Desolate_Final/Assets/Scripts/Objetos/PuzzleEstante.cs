using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleEstante : MonoBehaviour
{
    bool unload;
    bool Active = false;
    public GameObject Player;
    public Camera cam;
    public LayerMask LivroAzul;
    public LayerMask LivroVermelho;
    public LayerMask LivroVerde;
    public LayerMask ColliderVermelho;
    public LayerMask ColliderVerde;
    public LayerMask ColliderAzul;
    public LayerMask item;
    public GameObject livroVermelho;
    public GameObject colliderVermelho;
    public GameObject livroVerde;
    public GameObject colliderVerde;
    public GameObject livroAzul;
    public GameObject colliderAzul;
    private GameObject livro1;
    private GameObject livro2;
    private GameObject livro3;
    private GameObject collider1;
    private GameObject collider2;
    private GameObject collider3;
    public bool passo;
    public bool passo1;
    public bool passo2;
    public bool passo3;
    public GameObject mouse;
    private GerenciadorCena gen;

    private void Start()
    {
        gen = GameObject.FindGameObjectWithTag("Interact").GetComponent<GerenciadorCena>();
    }
    void Update()
    {
        EstanteLivro();
        livro1 = GameObject.FindGameObjectWithTag("LivroVermelho");
        livro2 = GameObject.FindGameObjectWithTag("LivroVerde");
        livro3 = GameObject.FindGameObjectWithTag("LivroAzul");
        collider1 = GameObject.FindGameObjectWithTag("ColliderVermelho");
        collider2 = GameObject.FindGameObjectWithTag("ColliderAzul");
        collider3 = GameObject.FindGameObjectWithTag("ColliderVerde");
    }

    public void EstanteLivro()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        #region Livro vermelho
        #region Passo True
        if (Physics.Raycast(ray, out hit, 100, LivroVermelho))
        {
            if (Input.GetMouseButtonDown(0))
            {
               livroVermelho.transform.position = new Vector3(mouse.transform.position.x, mouse.transform.position.y, mouse.transform.position.z);
               if (livroVermelho.transform.position == mouse.transform.position)
               {
                   livroAzul.GetComponent<Collider>().enabled = false;
                   livroVerde.GetComponent<Collider>().enabled = false;
               }
            }
        }
        
        
        if(livroVermelho.transform.position == mouse.transform.position)
        {
            if (Physics.Raycast(ray, out hit, 100, ColliderVermelho))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    livroVermelho.transform.position = new Vector3(colliderVermelho.transform.position.x, colliderVermelho.transform.position.y, colliderVermelho.transform.position.z);
                    if (livroVermelho.transform.position == colliderVermelho.transform.position)
                    {
                        livroAzul.GetComponent<Collider>().enabled = true;
                        livroVerde.GetComponent<Collider>().enabled = true;
                        colliderVermelho.GetComponent<Collider>().enabled = false;
                        passo = true;
                    }
                }             
            }
            if (livroVermelho.transform.position == mouse.transform.position)
            {

                colliderVermelho.GetComponent<Collider>().enabled = true;
            }
        }
        #endregion


        if (livroVermelho.transform.position == mouse.transform.position)
        {
            if (Physics.Raycast(ray, out hit, 100, ColliderAzul))
            { 
                if (Input.GetMouseButtonDown(0))
                {
                    livroVermelho.transform.position = new Vector3(colliderAzul.transform.position.x, colliderAzul.transform.position.y, colliderAzul.transform.position.z);
                    if (livroVermelho.transform.position == colliderAzul.transform.position)
                    {
                        livroAzul.GetComponent<Collider>().enabled = true;
                        livroVerde.GetComponent<Collider>().enabled = true;
                        colliderAzul.GetComponent<Collider>().enabled = false;
                    }
                }
            }
            if (livroVermelho.transform.position == mouse.transform.position)
            {

                colliderAzul.GetComponent<Collider>().enabled = true;
            }
        }

        if (livroVermelho.transform.position == mouse.transform.position)
        {
            if (Physics.Raycast(ray, out hit, 100, ColliderVerde))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    livroVermelho.transform.position = new Vector3(colliderVerde.transform.position.x, colliderVerde.transform.position.y, colliderVerde.transform.position.z);
                    if (livroVermelho.transform.position == colliderVerde.transform.position)
                    {
                        livroAzul.GetComponent<Collider>().enabled = true;
                        livroVerde.GetComponent<Collider>().enabled = true;
                        colliderVerde.GetComponent<Collider>().enabled = false;
                    }
                }
            }
            if (livroVermelho.transform.position == mouse.transform.position)
            {
                colliderVerde.GetComponent<Collider>().enabled = true;
            }
        }
        #endregion



        #region Livro Verde
        #region Passo1 True
        if (Physics.Raycast(ray, out hit, 100, LivroVerde))
        {
           if (Input.GetMouseButtonDown(0))
           {
              livroVerde.transform.position = new Vector3(mouse.transform.position.x, mouse.transform.position.y, mouse.transform.position.z);
              if (livroVerde.transform.position == mouse.transform.position)
              {
                 
                 livroAzul.GetComponent<Collider>().enabled = false;
                 livroVermelho.GetComponent<Collider>().enabled = false;

              }
           }
        } 

        if(livroVerde.transform.position == mouse.transform.position)
        {
            if (Physics.Raycast(ray, out hit, 100, ColliderVerde))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    livroVerde.transform.position = new Vector3(colliderVerde.transform.position.x, colliderVerde.transform.position.y, colliderVerde.transform.position.z);
                    if (livroVerde.transform.position == colliderVerde.transform.position)
                    {
                        colliderVerde.GetComponent<Collider>().enabled = false;
                        livroAzul.GetComponent<Collider>().enabled = true;
                        livroVermelho.GetComponent<Collider>().enabled = true;
                        passo1 = true;
                    }
                }
            }
            if (livroVerde.transform.position == mouse.transform.position)
            {

                colliderVerde.GetComponent<Collider>().enabled = true;
            }
        }
        #endregion

        if (livroVerde.transform.position == mouse.transform.position)
        {
            if (Physics.Raycast(ray, out hit, 100, ColliderAzul))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    livroVerde.transform.position = new Vector3(colliderAzul.transform.position.x, colliderAzul.transform.position.y, colliderAzul.transform.position.z);
                    if (livroVerde.transform.position == colliderAzul.transform.position)
                    {
                        livroAzul.GetComponent<Collider>().enabled = true;
                        livroVermelho.GetComponent<Collider>().enabled = true;
                        colliderAzul.GetComponent<Collider>().enabled = false;
                    }
                }
            }
            if (livroVerde.transform.position == mouse.transform.position)
            {

                colliderAzul.GetComponent<Collider>().enabled = true;
            }
        }

        if (livroVerde.transform.position == mouse.transform.position)
        {
            if (Physics.Raycast(ray, out hit, 100, ColliderVermelho))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    livroVerde.transform.position = new Vector3(colliderVermelho.transform.position.x, colliderVermelho.transform.position.y, colliderVermelho.transform.position.z);
                    if (livroVerde.transform.position == colliderVermelho.transform.position)
                    {
                        livroAzul.GetComponent<Collider>().enabled = true;
                        livroVermelho.GetComponent<Collider>().enabled = true;
                        colliderVermelho.GetComponent<Collider>().enabled = false;
                    }
                }
            }
            if (livroVerde.transform.position == mouse.transform.position)
            {
                colliderVermelho.GetComponent<Collider>().enabled = true;
            }
        }
        #endregion




        #region Livro Azul
        #region Passo2 True
        if (Physics.Raycast(ray, out hit, 100, LivroAzul))
        {
            if (Input.GetMouseButtonDown(0))
            {
                livroAzul.transform.position = new Vector3(mouse.transform.position.x, mouse.transform.position.y, mouse.transform.position.z);
                if (livroAzul.transform.position == mouse.transform.position)
                {
                    
                    livroVerde.GetComponent<Collider>().enabled = false;
                    livroVermelho.GetComponent<Collider>().enabled = false;
                }
            }
        }
        
       
        if(livroAzul.transform.position == mouse.transform.position)
        {
            if (Physics.Raycast(ray, out hit, 100, ColliderAzul))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    livroAzul.transform.position = new Vector3(colliderAzul.transform.position.x, colliderAzul.transform.position.y, colliderAzul.transform.position.z);
                    if (livroAzul.transform.position == colliderAzul.transform.position)
                    {
                        colliderAzul.GetComponent<Collider>().enabled = false;
                        livroVerde.GetComponent<Collider>().enabled = true;
                        livroVermelho.GetComponent<Collider>().enabled = true;
                        passo2 = true;
                        
                    }
                }
            }
            if (livroAzul.transform.position == mouse.transform.position)
            {
                colliderAzul.GetComponent<Collider>().enabled = true;
            }
        }
        #endregion


        if (livroAzul.transform.position == mouse.transform.position)
        {
            if (Physics.Raycast(ray, out hit, 100, ColliderVerde))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    livroAzul.transform.position = new Vector3(colliderVerde.transform.position.x, colliderVerde.transform.position.y, colliderVerde.transform.position.z);
                    if (livroAzul.transform.position == colliderVerde.transform.position)
                    {
                        livroVerde.GetComponent<Collider>().enabled = true;
                        livroVermelho.GetComponent<Collider>().enabled = true;
                        colliderVerde.GetComponent<Collider>().enabled = false;
                    }
                }
            }
            if (livroAzul.transform.position == mouse.transform.position)
            {

                colliderVerde.GetComponent<Collider>().enabled = true;
            }
        }

        if (livroAzul.transform.position == mouse.transform.position)
        {
            if (Physics.Raycast(ray, out hit, 100, ColliderVermelho))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    livroAzul.transform.position = new Vector3(colliderVermelho.transform.position.x, colliderVermelho.transform.position.y, colliderVermelho.transform.position.z);
                    if (livroAzul.transform.position == colliderVermelho.transform.position)
                    {
                        livroVerde.GetComponent<Collider>().enabled = true;
                        livroVermelho.GetComponent<Collider>().enabled = true;
                        colliderVermelho.GetComponent<Collider>().enabled = false;
                    }
                }
            }
            if (livroAzul.transform.position == mouse.transform.position)
            {

                colliderVermelho.GetComponent<Collider>().enabled = true;
            }
        }


        #endregion

        if (passo && passo1 && passo2 == true)
        {
            passo3 = true;
            if(passo3 == true)
            {
                gen.estanteConcluida = true;
                
                
            }
        }


    }
}
