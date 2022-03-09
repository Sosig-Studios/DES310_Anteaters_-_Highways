using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCollision : MonoBehaviour
{
    public CarScript carScript;

    void Update()
    {
        TrafficDetect();
    }

    void TrafficDetect()
    {

        LayerMask mask = (1 << 8);

      
        var dist = 5.0f;

        RaycastHit hit1;
        Debug.DrawRay(transform.position, Vector3.forward * dist, Color.green);
    
        if(Physics.Raycast(transform.position, Vector3.forward, out hit1, dist, mask))
        {
            
            Debug.Log("Car hit");
            StartCoroutine(StopCar());

        }

    }


    IEnumerator StopCar()
    {
        carScript.speed = 0;
        yield return new WaitForSeconds(0.3f);
        carScript.speed = 5;
        
        
    }

}
