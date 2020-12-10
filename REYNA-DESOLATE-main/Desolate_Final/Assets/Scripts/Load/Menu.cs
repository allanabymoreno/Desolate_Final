using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Andar2");
        //SceneManager.LoadScene("MainScene");
    }

    public void QualityChange()
    {
        QualitySettings.SetQualityLevel(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
