using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public GameObject panel;
    public void GameStart() 
    {
        SceneManager.LoadScene("Runner");
    }

    public void ScoreSC()
    {
        SceneManager.LoadScene("Records");
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void YouSure() 
    {
        if (!panel.activeSelf) 
        {
            panel.SetActive(true);
        }
        else 
        {
            panel.SetActive(false);
        }
    }
    public void EXIT()
    {
        Application.Quit();
    }


}
