using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeWinScript : MonoBehaviour
{
    int antEaterNum = 0;
    public int antEaterNumMax;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "AntEater")
        {
            antEaterNum++;
            Debug.Log("Anteater Hit Tree");
            Destroy(collisionInfo.gameObject);
        }

        if (antEaterNum == antEaterNumMax)
        {
            endLevel();//ends level...
        }
    }

    void endLevel()
    {
        SceneManager.LoadScene("WinState"); //load win state 
    }
}

