using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CarAlert : MonoBehaviour
{
  

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Car")
        {
          
            Debug.Log("Car Alert Hit Car");
        }

        if (collisionInfo.gameObject.tag == "AntEater")
        {
    
            Debug.Log("Anteater Hit box alert");
        }

       

    }

    void TrafficDetect()
    {

        LayerMask mask = (1 << 8);


        var dist = 5.0f;

        RaycastHit hit1;
        Debug.DrawRay(transform.position, -Vector3.forward * dist, Color.green);

        if (Physics.Raycast(transform.position, -Vector3.forward, out hit1, dist, mask))
        {

             Debug.Log("Car hit bx alert");
            //StartCoroutine(StopCar());
            //carScript.speed = 0;

        }
  
    }

    void Update()
    {
        TrafficDetect();
    }


}

/*
 Collide with car
spawn image
*/