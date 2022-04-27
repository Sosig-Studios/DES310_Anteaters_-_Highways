using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedButtons : MonoBehaviour
{
    //private float speedModifier;
    public int speedModifier;

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 1;
        //Debug.Log("Speed Modifier = 1");
    }

    public void setNormalSpeed()
    {
        speedModifier = 1;
        //Debug.Log("Speed Modifier = 1");
    }

    public void setFastSpeed()
    {
        speedModifier = 2;
        //Debug.Log("Speed Modifier = 2");
    }

    public void setMaxSpeed()
    {
        speedModifier = 3;
        //Debug.Log("Speed Modifier = 3");
    }

    public int getSpeedModifier() { return speedModifier; }

}


/*
 Set up a float call speed modifier 
public or private with a getter

set normal speed
set fast speed
set max speed
 */