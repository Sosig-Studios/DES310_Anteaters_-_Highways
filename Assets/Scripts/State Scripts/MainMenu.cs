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

    public void LoadCredits()
    {
        //SceneManager.LoadScene("CreditsScreen");
        StartCoroutine(CreditLoader());
    }

    public void LoadHTP()
    {
        //SceneManager.LoadScene("HowToPlay");
        StartCoroutine(HTPLoader());
    }


    IEnumerator CreditLoader()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("CreditsScreen");
    }

    IEnumerator HTPLoader()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("HowToPlay");
    }

}
