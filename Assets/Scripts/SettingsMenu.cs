using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

  public void SetVolume (float volume)
    {
        //Debug.Log(volume);
        audioMixer.SetFloat("Volume", volume);
    }

    public void LoadMenu()
    {
        Debug.Log("Load Menu");
        SceneManager.LoadScene("MainMenu");
    }
}
