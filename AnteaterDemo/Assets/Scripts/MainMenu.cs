using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_1");//loads first level
       
    }

    public void QuitGame()
    {
        // Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }


}
