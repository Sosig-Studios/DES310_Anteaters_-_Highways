using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCollision : MonoBehaviour
{
 

    void OnCollisionEnter(UnityEngine.Collision col)
    {
        if(col.gameObject.tag == "LevelEnd")
        {
            print("Anteater Completed Level!");
            endLevel();// ends level...
        }
    }


    void endLevel()
    {
        SceneManager.LoadScene("WinState"); //load win state 
    }
}
