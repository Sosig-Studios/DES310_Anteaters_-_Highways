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
        //load next level...
        SceneManager.LoadScene("LVL2");
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