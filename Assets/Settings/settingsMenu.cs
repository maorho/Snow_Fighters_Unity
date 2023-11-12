using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.Audio;
public class settingsMenu : MonoBehaviour
{
    [SerializeField] public Text duration;
    public static int durationInSec = 60;
    public AudioMixer audioMixer;
    public void returnStart()
    {
        SceneManager.LoadScene(0);
    }
    public void textUpdate(float time)
    {
        duration.text = Mathf.RoundToInt(time) + " seconds";
        durationInSec = Mathf.RoundToInt(time);
    }
    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
