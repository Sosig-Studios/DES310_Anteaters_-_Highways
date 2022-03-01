using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinStateScript : MonoBehaviour
{
    public void nextLevel()
    {
        SceneManager.LoadScene("Level_2");//loads next level if player press continue...
    }
}
