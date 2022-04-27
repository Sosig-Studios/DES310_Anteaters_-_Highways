using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinState : MonoBehaviour
{
    public LevelInformation levelInformationScript;

    public Image levelScrenshotImage;
    public Sprite levelScreenShot1Image;
    public Sprite levelScreenShot2Image;

    private int currentLevelNumber;

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
        currentLevelNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("working");
        Debug.Log(currentLevelNumber);
        currentLevelNumber = levelInformationScript.getCurrentLevelNumber();
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
}