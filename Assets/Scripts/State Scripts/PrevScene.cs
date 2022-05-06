using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrevScene : MonoBehaviour
{
    public string prevScene;
    public string curScene;
    
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        curScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if(curScene != SceneManager.GetActiveScene().name)
        {
            prevScene = curScene;
            curScene = SceneManager.GetActiveScene().name;
        }
    }
}
