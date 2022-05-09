using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseState : MonoBehaviour
{
    public static int currentLevelNumber;

    public void Retry()
    {
        Time.timeScale = 1f;
        if (GameObject.FindGameObjectWithTag("prev scene") != null)
        {
            var prev = GameObject.FindGameObjectWithTag("prev scene").GetComponent<PrevScene>().prevScene;
            SceneManager.LoadScene(prev);
        }
        else
            SceneManager.LoadScene("LevelSelect");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");//goes back to main menu

    }

    
}
