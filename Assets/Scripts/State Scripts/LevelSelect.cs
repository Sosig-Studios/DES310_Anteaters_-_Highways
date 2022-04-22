using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/

    // Update is called once per frame
  /*  void Update()
    {
        
    }*/



    public void PlayLevel1()
    {
        SceneManager.LoadScene("LVL1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("LVL2");
    }

}
