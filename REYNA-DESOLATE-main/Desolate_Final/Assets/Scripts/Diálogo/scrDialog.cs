using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scrDialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public int index;
    public float typingSpeed;
    public bool podePassarFala=true;
    public GameObject informandoJogador;
    public AudioSource fxNext;
    public scrDeteccaoFala scrDeteccaoFala;
    public mouseLook1st scrMouseLook;
    public PlayerMovement scrPM;


    //private scrDialog scrDialogV;

    void Start(){
        StartCoroutine(Type());
    }

    void Update(){

        if(textDisplay.text == sentences[index]){
            podePassarFala = true;
            informandoJogador.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            scrDeteccaoFala.FadeOut();
            scrDeteccaoFala.uiCanvas.SetActive(false);
            scrMouseLook.podeOlhar=true;
            scrPM.possoMover=true;
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && podePassarFala)
        {
            fxNext.Play();
            NextSentence();
        }
    }
    IEnumerator Type(){

        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        
    }

    public void NextSentence(){

        podePassarFala =false;
        informandoJogador.SetActive(false);

        if(index < sentences.Length - 1){
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }else{

            textDisplay.text = "";
            podePassarFala = false;
            informandoJogador.SetActive(false);
            


            scrMouseLook.podeOlhar=true;
            scrPM.possoMover=true;

            scrDeteccaoFala.FadeOut();
            scrDeteccaoFala.uiCanvas.SetActive(false);
        }

        
    }

}
