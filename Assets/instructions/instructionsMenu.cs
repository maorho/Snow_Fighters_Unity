using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class instructionsMenu : MonoBehaviour
{
    public void levelsMenu()
    {
        SceneManager.LoadScene(3);
    }
    public void retStart()
    {
        SceneManager.LoadScene(0);
    }
}
