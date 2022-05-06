using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedButtons : MonoBehaviour
{
    //private float speedModifier;
    public int speedModifier;

    public float NormalSpeed = 1;
    public float FastSpeed = 1.25f;
    public float MaxSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 1;
        //Debug.Log("Speed Modifier = 1");
    }

    void Update()
    {
        if (Input.GetKey("1"))
        {
            setNormalSpeed();
        }
        if (Input.GetKey("2"))
        {
            setFastSpeed();
        }
        if (Input.GetKey("3"))
        {
            setMaxSpeed();
        }
        Debug.Log(Time.timeScale);
    }

    public void setNormalSpeed()
    {
        //speedModifier = 1;
        //Debug.Log("Speed Modifier = 1");
        Time.timeScale = NormalSpeed;
    }

    public void setFastSpeed()
    {
        //speedModifier = 2;
        //Debug.Log("Speed Modifier = 2");
        Time.timeScale = FastSpeed;
    }

    public void setMaxSpeed()
    {
        //speedModifier = 3;
        //Debug.Log("Speed Modifier = 3");
        Time.timeScale = MaxSpeed;
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