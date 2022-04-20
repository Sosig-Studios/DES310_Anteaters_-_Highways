using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseState : MonoBehaviour
{


    public void Retry()
    {
        Debug.Log("Retry Game");
        Time.timeScale = 1f;
        SceneManager.LoadScene("LVL1");//takes player back to level 1...
    } 

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");//goes back to main menu

    }
}
