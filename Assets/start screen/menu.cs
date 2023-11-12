using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void levelsMenu()
    {
        SceneManager.LoadScene(3);
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void setting()
    {
        SceneManager.LoadScene(4);
    }
    public void instructionsToGame()
    {
        SceneManager.LoadScene(2);
    }
}
