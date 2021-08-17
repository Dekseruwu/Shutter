using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class Menu : MonoBehaviour
{
    public void buttonBack()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void buttonStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }

    public void buttonDemo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void buttonCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void buttonQuit()
    {
        Application.Quit();
    }
}