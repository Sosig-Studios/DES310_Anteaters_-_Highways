using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInformation : MonoBehaviour
{
    public int currentLevelNumber; 

    public int getCurrentLevelNumber() { return currentLevelNumber; }

    // Start is called before the first frame update
    void Start()
    {
        WinState.currentLevelNumber = currentLevelNumber;
        LoseState.currentLevelNumber = currentLevelNumber;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
