using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trucksAnimationtTest : MonoBehaviour
{
    public Animation truckBrake;

    // Start is called before the first frame update
    void Start()
    {
        truckBrake = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            truckBrake.Play();
        }
        else if (Input.GetKeyUp("d"))
        {
            truckBrake.Stop();
        }
    }
}
