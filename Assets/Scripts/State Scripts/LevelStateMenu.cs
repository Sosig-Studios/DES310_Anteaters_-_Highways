using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelStateMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject hudUI;
    public AudioSource levelMusic;

    public Image hudPauseImage;

    private void Start()
    {
        hudPauseImage.enabled = false;
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
    }
        // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void Resume()
    {
        hudPauseImage.enabled = false;
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        levelMusic.Play();
    }

    public void PauseGame()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    void Pause()
    {
        //set hud pause to active
        hudPauseImage.enabled = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        levelMusic.Pause();
    }

    public void LoadMainMenu()
    {
        Debug.Log("Load Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void RetryGame()
    {
        Debug.Log("Retry Game");
        Time.timeScale = 1f;
        SceneManager.LoadScene("FPlayable_LVL1");
    }

    public void LoadSettingsMenu()
    {

        Debug.Log("Settings menu hit");
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadHowToPlayMenu()
    {

        Debug.Log("How To Play Menu Hit");

    }
}
