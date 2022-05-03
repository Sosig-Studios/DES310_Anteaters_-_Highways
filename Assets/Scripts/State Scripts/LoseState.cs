using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseState : MonoBehaviour
{
    public static int currentLevelNumber;

    public void Retry()
    {
        Debug.Log("Retry Game");
        //Time.timeScale = 1f;
        //SceneManager.LoadScene("LevelSelect");//takes player back to level 1...
        switch (currentLevelNumber)
        {
            case 1:
                //if current level one load level 1 on retry
                Time.timeScale = 1f;
                SceneManager.LoadScene("LVL1");
                break;
            case 2:
                //if current level two load level 2 on retry
                Time.timeScale = 1f;
                SceneManager.LoadScene("LVL2");
                break;
            case 3:
                //if current level three load level 3 on retry
                Time.timeScale = 1f;
                SceneManager.LoadScene("LVL3");
                break;
            default:
                Debug.Log("not working");
                break;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");//goes back to main menu

    }

    
}
