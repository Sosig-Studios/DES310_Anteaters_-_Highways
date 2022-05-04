using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinState : MonoBehaviour
{

    public static int currentLevelNumber;

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
        Debug.Log("To Next Level");
        switch(currentLevelNumber)
        {
            case 1:
                //if level one move to level 2
                SceneManager.LoadScene("LVL2");
                break;
            case 2:
                //if level 2 move to level 3
                SceneManager.LoadScene("LVL3");
                break;
            case 3:
                //if level move to credits
                SceneManager.LoadScene("CreditsScreen");
                break;
            default:
                Debug.Log("not working");
                Debug.Log(currentLevelNumber);
                break;


        }
    }

    public void setCurrentLevelNumber(int i) { currentLevelNumber = i; }

    // Start is called before the first frame update
    void Start()
    {
        //currentLevelNumber = 0;
        Debug.Log("working");
        Debug.Log(currentLevelNumber);
        switch (currentLevelNumber)
        {
            case 1:
                levelScrenshotImage.sprite = levelScreenShot1Image;
                break;
            case 2:
                levelScrenshotImage.sprite = levelScreenShot2Image;
                break;
            default:
                // code block
                levelScrenshotImage.sprite = levelScreenShot1Image;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}