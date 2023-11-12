using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuLevels : MonoBehaviour
{
    public void playlevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void playlevel2()
    {
        SceneManager.LoadScene(5);
    }
    public void playlevel3()
    {
        SceneManager.LoadScene(6);
    }
}
