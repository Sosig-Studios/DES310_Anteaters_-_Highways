using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinState : MonoBehaviour
{
 
    public void LoadMenu()
    {
        Debug.Log("Back To Menu");
        SceneManager.LoadScene("MainMenu"); //goes back to menu 
    }

    public void NextLevel()
    {
        Debug.Log("To Next Level");
        //load next level...
    }
}
