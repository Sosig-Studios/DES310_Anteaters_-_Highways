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
        hudUI.SetActive(true);
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
            GameObject.FindGameObjectWithTag("Level Music").GetComponent<AudioSource>().Play();
        }
        else
        {
            Pause();
            GameObject.FindGameObjectWithTag("Level Music").GetComponent<AudioSource>().Pause();
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
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RetryGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("FPlayable_LVL1");
    }

    public void LoadSettingsMenu()
    {

        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadHowToPlayMenu()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
