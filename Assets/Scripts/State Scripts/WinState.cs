using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinState : MonoBehaviour
{


    public Image levelScrenshotImage;
    public Sprite levelScreenShot1Image;
    public Sprite levelScreenShot2Image;

    

    public void LoadMenu()
    {
        Debug.Log("Back To Menu");
        SceneManager.LoadScene("MainMenu"); //goes back to menu 
    }

    public void NextLevel()
    {
        var prev = "";
        if (GameObject.FindGameObjectWithTag("prev scene") != null)
        {
            prev = GameObject.FindGameObjectWithTag("prev scene").GetComponent<PrevScene>().prevScene;
            SceneManager.LoadScene(prev);
        }
        else
            SceneManager.LoadScene("LevelSelect");
        switch (prev)
        {
            case "LVL1":
                //if level one move to level 2
                SceneManager.LoadScene("LVL2");
                break;
            case "LVL2":
                //if level 2 move to level 3
                SceneManager.LoadScene("LVL3");
                break;
            case "LVL3":
                //if level move to credits
                SceneManager.LoadScene("CreditsScreen");
                break;
            default:
                Debug.Log("not working");
                break;


        }
    }

    

    // Update is called once per frame
    void Update()
    {

    }
}