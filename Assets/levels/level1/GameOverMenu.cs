using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void returnStart()
    {
        SceneManager.LoadScene(0);
    }
    public void levelsMenu()
    {
        SceneManager.LoadScene(3);
    }
}
