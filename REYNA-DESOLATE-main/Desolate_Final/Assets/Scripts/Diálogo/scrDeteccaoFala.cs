using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrDeteccaoFala : MonoBehaviour
{
    public GameObject uiCanvas;
    public CanvasGroup uiElement;
    public bool possoColidir=true;
    public mouseLook1st scrMouseLook;
    public PlayerMovement scrPM;
    public scrDialog scrDialog;

    public void FadeIn(){
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha,1));
    }
    public void FadeOut(){
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha,0));
    }

    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 1f)
    {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted/lerpTime;

        while(true)
        {
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;

            float currentValue = Mathf.Lerp(start,end,percentageComplete);

            cg.alpha = currentValue;

            if(percentageComplete >= 1) break;

            yield return new WaitForEndOfFrame();
        }
    }

    void OnTriggerStay(Collider quem)
    {
        if (quem.gameObject.tag == "Player" && possoColidir==true)
        {
            if(scrDialog.index <= 6){
                scrDialog.index=0;
                scrDialog.podePassarFala=true;
            }


            scrMouseLook.podeOlhar=false;
            scrPM.possoMover=false;

            uiCanvas.SetActive(true);
            FadeIn();
            possoColidir=false;
        }

    }

}
