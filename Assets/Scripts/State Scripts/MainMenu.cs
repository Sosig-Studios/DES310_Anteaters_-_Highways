using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject levelSelect;
    private void Start()
    {
        levelSelect.SetActive(false);
    }
    public void PlayGame()
    {

        levelSelect.SetActive(true);
       
    }

    public void LevelSelectReturn()
    {

        levelSelect.SetActive(false);
    }

}
