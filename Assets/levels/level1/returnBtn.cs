using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnBtn : MonoBehaviour
{
    public void retStart()
    {
        SceneManager.LoadScene(0);
    }
}
