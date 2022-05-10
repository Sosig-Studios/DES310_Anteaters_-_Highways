using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public CarScript carScript;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "AntEater")
        {
            Debug.Log("Car Hit Anteater");
            StartCoroutine(StopCar());

        }

        if (collisionInfo.gameObject.tag == "CarAlert")
        {
            Debug.Log("Car Hit Car Alert");
            StartCoroutine(StopCar());

        }



    }

    IEnumerator StopCar()
    {
        carScript.setSpeed = -7;
        yield return new WaitForSeconds(0.05f);
        carScript.setSpeed = 7;
        yield return new WaitForSeconds(0.2f);
        carScript.setSpeed = 0;
    }
}
